namespace EmployeePhotoViewer
{
	partial class frmEmployeePhotoViewer
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblEmployeeID = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.picEmployeePhoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblTitle.Location = new System.Drawing.Point(273, 66);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(247, 41);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Employee Photo";
			// 
			// lblEmployeeID
			// 
			this.lblEmployeeID.AutoSize = true;
			this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmployeeID.Location = new System.Drawing.Point(99, 146);
			this.lblEmployeeID.Name = "lblEmployeeID";
			this.lblEmployeeID.Size = new System.Drawing.Size(104, 20);
			this.lblEmployeeID.TabIndex = 1;
			this.lblEmployeeID.Text = "Employee ID";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmployeeID.Location = new System.Drawing.Point(238, 141);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(200, 30);
			this.txtEmployeeID.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(238, 189);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(200, 35);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// picEmployeePhoto
			// 
			this.picEmployeePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picEmployeePhoto.Location = new System.Drawing.Point(474, 129);
			this.picEmployeePhoto.Name = "picEmployeePhoto";
			this.picEmployeePhoto.Size = new System.Drawing.Size(260, 300);
			this.picEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picEmployeePhoto.TabIndex = 4;
			this.picEmployeePhoto.TabStop = false;
			// 
			// frmEmployeePhotoViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(767, 457);
			this.Controls.Add(this.picEmployeePhoto);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.lblEmployeeID);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmEmployeePhotoViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Photo Viewer";
			((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEmployeeID;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.PictureBox picEmployeePhoto;
	}
}

