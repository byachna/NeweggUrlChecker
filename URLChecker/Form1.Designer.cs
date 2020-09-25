namespace URLChecker
{
	partial class frmMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgItemView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRunToggle = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tslblTimer = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslblLastRefresh = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslblNextRefresh = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslblSecondsLeft = new System.Windows.Forms.ToolStripStatusLabel();
			this.tspbRefresh = new System.Windows.Forms.ToolStripProgressBar();
			this.chkInStock = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSortBy = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgItemView)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Item Status";
			// 
			// dgItemView
			// 
			this.dgItemView.AllowUserToAddRows = false;
			this.dgItemView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgItemView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgItemView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgItemView.Location = new System.Drawing.Point(12, 65);
			this.dgItemView.Name = "dgItemView";
			this.dgItemView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgItemView.Size = new System.Drawing.Size(888, 571);
			this.dgItemView.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "URL";
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.Location = new System.Drawing.Point(48, 10);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(860, 20);
			this.txtUrl.TabIndex = 4;
			this.txtUrl.Text = "https://www.newegg.com/p/pl?N=100007709%20601357282";
			// 
			// txtInterval
			// 
			this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInterval.Location = new System.Drawing.Point(763, 38);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(60, 20);
			this.txtInterval.TabIndex = 5;
			this.txtInterval.Text = "15";
			this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(690, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Interval (sec.)";
			// 
			// btnRunToggle
			// 
			this.btnRunToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunToggle.Location = new System.Drawing.Point(832, 36);
			this.btnRunToggle.Name = "btnRunToggle";
			this.btnRunToggle.Size = new System.Drawing.Size(75, 23);
			this.btnRunToggle.TabIndex = 7;
			this.btnRunToggle.Text = "Run";
			this.btnRunToggle.UseVisualStyleBackColor = true;
			this.btnRunToggle.Click += new System.EventHandler(this.btnRunToggle_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTimer,
            this.tslblLastRefresh,
            this.toolStripStatusLabel1,
            this.tslblNextRefresh,
            this.tslblSecondsLeft,
            this.tspbRefresh});
			this.statusStrip1.Location = new System.Drawing.Point(0, 639);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(912, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tslblTimer
			// 
			this.tslblTimer.Name = "tslblTimer";
			this.tslblTimer.Size = new System.Drawing.Size(73, 17);
			this.tslblTimer.Text = "Last Refresh:";
			// 
			// tslblLastRefresh
			// 
			this.tslblLastRefresh.Name = "tslblLastRefresh";
			this.tslblLastRefresh.Size = new System.Drawing.Size(37, 17);
			this.tslblLastRefresh.Text = "(N/A)";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabel1.Text = "Next Refresh:";
			// 
			// tslblNextRefresh
			// 
			this.tslblNextRefresh.Name = "tslblNextRefresh";
			this.tslblNextRefresh.Size = new System.Drawing.Size(37, 17);
			this.tslblNextRefresh.Text = "(N/A)";
			// 
			// tslblSecondsLeft
			// 
			this.tslblSecondsLeft.Name = "tslblSecondsLeft";
			this.tslblSecondsLeft.Size = new System.Drawing.Size(0, 17);
			// 
			// tspbRefresh
			// 
			this.tspbRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tspbRefresh.Name = "tspbRefresh";
			this.tspbRefresh.Size = new System.Drawing.Size(100, 16);
			this.tspbRefresh.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
			// 
			// chkInStock
			// 
			this.chkInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkInStock.AutoSize = true;
			this.chkInStock.Location = new System.Drawing.Point(588, 40);
			this.chkInStock.Name = "chkInStock";
			this.chkInStock.Size = new System.Drawing.Size(96, 17);
			this.chkInStock.TabIndex = 9;
			this.chkInStock.Text = "In Stock Only?";
			this.chkInStock.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(394, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Sort By";
			// 
			// cbSortBy
			// 
			this.cbSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSortBy.FormattingEnabled = true;
			this.cbSortBy.Items.AddRange(new object[] {
            "Name",
            "Price"});
			this.cbSortBy.Location = new System.Drawing.Point(441, 38);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(121, 21);
			this.cbSortBy.TabIndex = 11;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 661);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chkInStock);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnRunToggle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInterval);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgItemView);
			this.Controls.Add(this.label1);
			this.Name = "frmMain";
			this.Text = "Newegg URL Checker by Europort";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgItemView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgItemView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.TextBox txtInterval;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRunToggle;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tslblTimer;
		private System.Windows.Forms.ToolStripStatusLabel tslblLastRefresh;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tslblNextRefresh;
		private System.Windows.Forms.ToolStripStatusLabel tslblSecondsLeft;
		private System.Windows.Forms.ToolStripProgressBar tspbRefresh;
		private System.Windows.Forms.CheckBox chkInStock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbSortBy;
	}
}

