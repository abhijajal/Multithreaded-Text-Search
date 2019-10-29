namespace apj180001Asg4
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.TxtfilePath = new System.Windows.Forms.TextBox();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.ListView();
            this.lineNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matchCase = new System.Windows.Forms.CheckBox();
            this.clickToCopy = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressPer = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrowse.Location = new System.Drawing.Point(713, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtfilePath
            // 
            this.TxtfilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtfilePath.Enabled = false;
            this.TxtfilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtfilePath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtfilePath.Location = new System.Drawing.Point(12, 12);
            this.TxtfilePath.Name = "TxtfilePath";
            this.TxtfilePath.ReadOnly = true;
            this.TxtfilePath.Size = new System.Drawing.Size(695, 23);
            this.TxtfilePath.TabIndex = 0;
            this.TxtfilePath.TabStop = false;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTerm.Enabled = false;
            this.txtSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchTerm.Location = new System.Drawing.Point(12, 41);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(695, 23);
            this.txtSearchTerm.TabIndex = 1;
            this.txtSearchTerm.TextChanged += new System.EventHandler(this.TxtSearchTerm_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(713, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // resultView
            // 
            this.resultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lineNum,
            this.line});
            this.resultView.Enabled = false;
            this.resultView.FullRowSelect = true;
            this.resultView.GridLines = true;
            this.resultView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.resultView.HideSelection = false;
            this.resultView.Location = new System.Drawing.Point(13, 101);
            this.resultView.MultiSelect = false;
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(775, 324);
            this.resultView.TabIndex = 6;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
            this.resultView.DoubleClick += new System.EventHandler(this.ResultView_DoubleClick);
            // 
            // lineNum
            // 
            this.lineNum.Text = "Line No.";
            this.lineNum.Width = 53;
            // 
            // line
            // 
            this.line.Text = "Line";
            this.line.Width = 700;
            // 
            // matchCase
            // 
            this.matchCase.AutoSize = true;
            this.matchCase.Location = new System.Drawing.Point(164, 2);
            this.matchCase.Name = "matchCase";
            this.matchCase.Size = new System.Drawing.Size(82, 17);
            this.matchCase.TabIndex = 4;
            this.matchCase.Text = "Match case";
            this.matchCase.UseVisualStyleBackColor = true;
            this.matchCase.CheckedChanged += new System.EventHandler(this.MatchCase_CheckedChanged);
            // 
            // clickToCopy
            // 
            this.clickToCopy.AutoSize = true;
            this.clickToCopy.Location = new System.Drawing.Point(4, 2);
            this.clickToCopy.Name = "clickToCopy";
            this.clickToCopy.Size = new System.Drawing.Size(123, 17);
            this.clickToCopy.TabIndex = 3;
            this.clickToCopy.Text = "Double-click to copy";
            this.clickToCopy.UseVisualStyleBackColor = true;
            this.clickToCopy.CheckedChanged += new System.EventHandler(this.ClickToCopy_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.progressPer);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.clickToCopy);
            this.panel1.Controls.Add(this.matchCase);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 31);
            this.panel1.TabIndex = 60;
            // 
            // progressPer
            // 
            this.progressPer.Location = new System.Drawing.Point(278, 5);
            this.progressPer.Name = "progressPer";
            this.progressPer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressPer.Size = new System.Drawing.Size(50, 13);
            this.progressPer.TabIndex = 61;
            this.progressPer.Text = "0%";
            this.progressPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(334, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 19);
            this.progressBar1.TabIndex = 60;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(187, 17);
            this.toolStripLabel.Text = "Open the file using browse button";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.TxtfilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Text Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox TxtfilePath;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader lineNum;
        private System.Windows.Forms.ColumnHeader line;
        private System.Windows.Forms.CheckBox matchCase;
        private System.Windows.Forms.CheckBox clickToCopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public  System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label progressPer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.ListView resultView;
    }
}

