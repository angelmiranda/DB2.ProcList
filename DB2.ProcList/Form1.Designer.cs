namespace DB2.ProcList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listButton = new System.Windows.Forms.Button();
            this.spListView = new System.Windows.Forms.DataGridView();
            this.numProcs = new System.Windows.Forms.NumericUpDown();
            this.procName = new System.Windows.Forms.TextBox();
            this.extractSpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allEnvsList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compareSPButton = new System.Windows.Forms.Button();
            this.folderBrowserSP = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(764, 29);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(75, 23);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "List SP";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // spListView
            // 
            this.spListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spListView.Location = new System.Drawing.Point(12, 77);
            this.spListView.Name = "spListView";
            this.spListView.Size = new System.Drawing.Size(1022, 438);
            this.spListView.TabIndex = 1;
            // 
            // numProcs
            // 
            this.numProcs.Location = new System.Drawing.Point(136, 30);
            this.numProcs.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numProcs.Name = "numProcs";
            this.numProcs.Size = new System.Drawing.Size(120, 20);
            this.numProcs.TabIndex = 2;
            this.numProcs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // procName
            // 
            this.procName.Location = new System.Drawing.Point(262, 30);
            this.procName.Name = "procName";
            this.procName.Size = new System.Drawing.Size(496, 20);
            this.procName.TabIndex = 3;
            // 
            // extractSpButton
            // 
            this.extractSpButton.Location = new System.Drawing.Point(6, 30);
            this.extractSpButton.Name = "extractSpButton";
            this.extractSpButton.Size = new System.Drawing.Size(75, 23);
            this.extractSpButton.TabIndex = 4;
            this.extractSpButton.Text = "Save";
            this.extractSpButton.UseVisualStyleBackColor = true;
            this.extractSpButton.Click += new System.EventHandler(this.extractSpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "List #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // allEnvsList
            // 
            this.allEnvsList.FormattingEnabled = true;
            this.allEnvsList.Location = new System.Drawing.Point(9, 29);
            this.allEnvsList.Name = "allEnvsList";
            this.allEnvsList.Size = new System.Drawing.Size(121, 21);
            this.allEnvsList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Env";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.allEnvsList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numProcs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.procName);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedure filter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Extract";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compareSPButton);
            this.groupBox2.Controls.Add(this.extractSpButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(863, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 60);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // compareSPButton
            // 
            this.compareSPButton.Location = new System.Drawing.Point(88, 30);
            this.compareSPButton.Name = "compareSPButton";
            this.compareSPButton.Size = new System.Drawing.Size(75, 23);
            this.compareSPButton.TabIndex = 5;
            this.compareSPButton.Text = "Compare";
            this.compareSPButton.UseVisualStyleBackColor = true;
            this.compareSPButton.Click += new System.EventHandler(this.compareSPButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 527);
            this.Controls.Add(this.spListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1060, 566);
            this.MinimumSize = new System.Drawing.Size(1060, 566);
            this.Name = "Form1";
            this.Text = "DB2 Procedure compare";
            ((System.ComponentModel.ISupportInitialize)(this.spListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.DataGridView spListView;
        private System.Windows.Forms.NumericUpDown numProcs;
        private System.Windows.Forms.TextBox procName;
        private System.Windows.Forms.Button extractSpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allEnvsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSP;
        private System.Windows.Forms.Button compareSPButton;
    }
}

