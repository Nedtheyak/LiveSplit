namespace LiveSplit.View
{
    partial class ActiveRunEditorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveRunEditorDialog));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBoxCurrentRun = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SplitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerCurrentRun = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelTimerControl = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSetTimer = new System.Windows.Forms.CheckBox();
            this.labelTimerControl = new System.Windows.Forms.Label();
            this.textBoxTimerControl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxCurrentRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRun)).BeginInit();
            this.splitContainerCurrentRun.Panel1.SuspendLayout();
            this.splitContainerCurrentRun.Panel2.SuspendLayout();
            this.splitContainerCurrentRun.SuspendLayout();
            this.tableLayoutPanelTimerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxCurrentRun);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.btnOK);
            this.splitContainerMain.Panel2.Controls.Add(this.btnCancel);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerMain.Size = new System.Drawing.Size(463, 686);
            this.splitContainerMain.SplitterDistance = 650;
            this.splitContainerMain.TabIndex = 1;
            // 
            // groupBoxCurrentRun
            // 
            this.groupBoxCurrentRun.Controls.Add(this.splitContainerCurrentRun);
            this.groupBoxCurrentRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCurrentRun.Location = new System.Drawing.Point(5, 5);
            this.groupBoxCurrentRun.Name = "groupBoxCurrentRun";
            this.groupBoxCurrentRun.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxCurrentRun.Size = new System.Drawing.Size(453, 640);
            this.groupBoxCurrentRun.TabIndex = 0;
            this.groupBoxCurrentRun.TabStop = false;
            this.groupBoxCurrentRun.Text = "Current Run";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Completed,
            this.SplitName,
            this.SplitTime});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(439, 582);
            this.dataGridView.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(258, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 22);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(358, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 22);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Completed
            // 
            this.Completed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            this.Completed.Width = 75;
            // 
            // SplitName
            // 
            this.SplitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SplitName.HeaderText = "Split Name";
            this.SplitName.Name = "SplitName";
            this.SplitName.ReadOnly = true;
            this.SplitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SplitTime
            // 
            this.SplitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SplitTime.HeaderText = "Time";
            this.SplitTime.Name = "SplitTime";
            this.SplitTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitContainerCurrentRun
            // 
            this.splitContainerCurrentRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCurrentRun.Location = new System.Drawing.Point(7, 22);
            this.splitContainerCurrentRun.Name = "splitContainerCurrentRun";
            this.splitContainerCurrentRun.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCurrentRun.Panel1
            // 
            this.splitContainerCurrentRun.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainerCurrentRun.Panel2
            // 
            this.splitContainerCurrentRun.Panel2.Controls.Add(this.tableLayoutPanelTimerControl);
            this.splitContainerCurrentRun.Size = new System.Drawing.Size(439, 611);
            this.splitContainerCurrentRun.SplitterDistance = 582;
            this.splitContainerCurrentRun.TabIndex = 1;
            // 
            // tableLayoutPanelTimerControl
            // 
            this.tableLayoutPanelTimerControl.ColumnCount = 3;
            this.tableLayoutPanelTimerControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTimerControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTimerControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanelTimerControl.Controls.Add(this.checkBoxSetTimer, 0, 0);
            this.tableLayoutPanelTimerControl.Controls.Add(this.labelTimerControl, 1, 0);
            this.tableLayoutPanelTimerControl.Controls.Add(this.textBoxTimerControl, 2, 0);
            this.tableLayoutPanelTimerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTimerControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTimerControl.Name = "tableLayoutPanelTimerControl";
            this.tableLayoutPanelTimerControl.RowCount = 1;
            this.tableLayoutPanelTimerControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTimerControl.Size = new System.Drawing.Size(439, 25);
            this.tableLayoutPanelTimerControl.TabIndex = 0;
            // 
            // checkBoxSetTimer
            // 
            this.checkBoxSetTimer.AutoSize = true;
            this.checkBoxSetTimer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSetTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSetTimer.Location = new System.Drawing.Point(0, 0);
            this.checkBoxSetTimer.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSetTimer.Name = "checkBoxSetTimer";
            this.checkBoxSetTimer.Size = new System.Drawing.Size(181, 25);
            this.checkBoxSetTimer.TabIndex = 0;
            this.checkBoxSetTimer.Text = "Set Timer:";
            this.checkBoxSetTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSetTimer.UseVisualStyleBackColor = true;
            // 
            // labelTimerControl
            // 
            this.labelTimerControl.AutoSize = true;
            this.labelTimerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimerControl.Location = new System.Drawing.Point(181, 0);
            this.labelTimerControl.Margin = new System.Windows.Forms.Padding(0);
            this.labelTimerControl.Name = "labelTimerControl";
            this.labelTimerControl.Size = new System.Drawing.Size(100, 25);
            this.labelTimerControl.TabIndex = 1;
            this.labelTimerControl.Text = "Timer Value: ";
            this.labelTimerControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTimerControl
            // 
            this.textBoxTimerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTimerControl.Location = new System.Drawing.Point(284, 3);
            this.textBoxTimerControl.Name = "textBoxTimerControl";
            this.textBoxTimerControl.Size = new System.Drawing.Size(152, 22);
            this.textBoxTimerControl.TabIndex = 2;
            // 
            // ActiveRunEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 686);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActiveRunEditorDialog";
            this.Text = "Run Editor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ActiveRunEditorDialog_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxCurrentRun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainerCurrentRun.Panel1.ResumeLayout(false);
            this.splitContainerCurrentRun.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRun)).EndInit();
            this.splitContainerCurrentRun.ResumeLayout(false);
            this.tableLayoutPanelTimerControl.ResumeLayout(false);
            this.tableLayoutPanelTimerControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxCurrentRun;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitTime;
        private System.Windows.Forms.SplitContainer splitContainerCurrentRun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTimerControl;
        private System.Windows.Forms.CheckBox checkBoxSetTimer;
        private System.Windows.Forms.Label labelTimerControl;
        private System.Windows.Forms.TextBox textBoxTimerControl;
    }
}