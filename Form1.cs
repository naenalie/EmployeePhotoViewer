using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace EmployeePhotoViewer
{
	public partial class frmEmployeePhotoViewer : Form
	{
		public frmEmployeePhotoViewer()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string employeeID = txtEmployeeID.Text.Trim();

			string connStr = "server=localhost;user=root;database=employee_db;password=;";
			MySqlConnection conn = new MySqlConnection(connStr);

			try
			{
				conn.Open();

				string query = "SELECT photo_path FROM employees WHERE employee_id=@id";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@id", employeeID);

				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					string path = reader["photo_path"].ToString();
					picEmployeePhoto.ImageLocation = Application.StartupPath + "\\" + path;
				}
				else
				{
					MessageBox.Show("Employee tidak ditemukan");
					picEmployeePhoto.Image = null;
				}

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
