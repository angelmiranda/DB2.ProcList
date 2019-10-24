using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2.ProcList
{
    public partial class Form1 : Form
    {
        private static DB2Connection _connection;
        private static DB2Command _command;
        private static DB2DataReader _reader;        

        public Form1()
        {
            InitializeComponent();

            //Load all environments combo
            NameValueCollection allEnvs = ConfigurationManager.GetSection("connStr") as NameValueCollection;
            foreach (string oneEnv in allEnvs)
            {
                allEnvsList.Items.Add(oneEnv);
            }
            allEnvsList.SelectedIndex = 0;
        }

        private static DataTable connectAndExecute(string Query, string envId)
        {
            try
            {
                var allEnvs = ConfigurationManager.GetSection("connStr") as System.Collections.Specialized.NameValueCollection;
                var env = allEnvs[envId];

                DataTable results = new DataTable();
                _connection = new DB2Connection(env);
                _connection.Open();

                if (_connection.IsOpen)
                {
                    _command = new DB2Command(Query, _connection);
                    _reader = _command.ExecuteReader();
                    results.Load(_reader);
                }
                _connection.Close();
                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string query = String.Format(ConfigurationManager.AppSettings["QueryListAll"], numProcs.Value, procName.Text);
                string env = allEnvsList.SelectedItem.ToString();

                spListView.DataSource = connectAndExecute(query, env);
                spListView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void extractSpButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (spListView.CurrentRow == null)
                {
                    MessageBox.Show("Please search and select one intem of the list first!");
                    return;
                }

                //Get folder
                folderBrowserSP.SelectedPath = ConfigurationManager.AppSettings["saveRoot"];
                var selectedSPFolder = folderBrowserSP.ShowDialog();

                //Save all files
                if (selectedSPFolder.ToString() == "OK")
                {
                    var envConfig = ConfigurationManager.GetSection("connStr") as System.Collections.Specialized.NameValueCollection;
                    foreach (string oneEnv in envConfig)
                    {
                        //Get query
                        string procedure = spListView.CurrentRow.Cells[0].Value.ToString();
                        string query = String.Format(ConfigurationManager.AppSettings["QueryContent"], procedure);

                        string rawTextQuery = "";
                        DataTable res = connectAndExecute(query, oneEnv);
                        if (res.Rows.Count > 0)
                            rawTextQuery = res.Rows[0][0].ToString();

                        string fileRoot = String.Format(folderBrowserSP.SelectedPath + "\\{0}-{1}.txt", oneEnv, procedure);
                        System.IO.File.WriteAllText(fileRoot, rawTextQuery);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void compareSPButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (spListView.CurrentRow == null)
                {
                    MessageBox.Show("Please search and select one intem of the list first!");
                    return;
                }                

                //Run comparison between procedures
                List<ProcedureComparison> allProcs = new List<ProcedureComparison>();

                var envConfig = ConfigurationManager.GetSection("connStr") as System.Collections.Specialized.NameValueCollection;
                foreach (string oneEnv in envConfig)
                {
                    //Get query
                    string procedureName = spListView.CurrentRow.Cells[0].Value.ToString();
                    string query = String.Format(ConfigurationManager.AppSettings["QueryContent"], procedureName);

                    string rawTextQuery = "";
                    DataTable res = connectAndExecute(query, oneEnv);
                    if (res.Rows.Count > 0)
                        rawTextQuery = res.Rows[0][0].ToString();

                    //Remove Tabs
                    rawTextQuery = rawTextQuery.Replace("\t", "");

                    //Remove carry return
                    rawTextQuery = rawTextQuery.Replace("\n", "");

                    //Remove extra spaces
                    while (rawTextQuery.Contains("  "))
                    {
                        rawTextQuery = rawTextQuery.Replace("  ", " ");
                    }

                    //Compare querys
                    if (allProcs.Count >= 1 && allProcs.Exists(p => p.ProcedureQuery.Equals(rawTextQuery)))
                    {
                        allProcs.Find(p => p.ProcedureQuery.Equals(rawTextQuery)).Environments.Add(oneEnv);
                    }
                    else
                    {
                        allProcs.Add(new ProcedureComparison()
                        {
                            ProcedureName = procedureName,
                            ProcedureQuery = rawTextQuery,
                            Environments = new List<string>() {
                        oneEnv }
                        });
                    }
                }

                //Display result
                string result = "";
                foreach (ProcedureComparison oneProc in allProcs)
                {
                    if (String.IsNullOrEmpty(result)) result += "Procedure " + oneProc.ProcedureName + "\n";

                    if (String.IsNullOrEmpty(oneProc.ProcedureQuery))
                        result += "- Not exists in; ";
                    else
                        result += "- Equal in; ";

                    foreach (string env in oneProc.Environments)
                    {
                        result += env + " ";
                    }
                    result += "\n";
                }
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
