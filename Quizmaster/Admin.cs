using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Quizmaster
{
    public partial class Admin : Form
    {
        SqlConnection coz = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
        public Admin()
        {
            InitializeComponent();

            FillComboBox();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM [Table] where Id=" + Convert.ToInt32(txtidupdate.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, coz);
                coz.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtusernameupdate.Text = dr["UserName"].ToString();
                    txtemailupdate.Text = dr["NIC"].ToString();
                    dtpbirthdayupdate.Text = dr["Birthdate"].ToString();

                }
                else
                {
                    MessageBox.Show("Invalid ID", "Quiz Master",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quiz Master",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                coz.Close();
            }
        }

        private void btnsubmitupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE [Table] SET UserName='" + txtusernameupdate.Text +"', NIC='" + txtemailupdate.Text + "' , Birthdate='" + dtpbirthdayupdate.MaxDate + "'";
                SqlCommand cmd = new SqlCommand(sql, coz);
                coz.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully updated", "Quiz Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally
            {
                coz.Close();

            }
        }



        protected void FillComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id FROM [Table]",coz);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmemid.DataSource = dt;
            cmbmemid.DisplayMember = "Id";
            cmbmemid.ValueMember = "Id";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you need to delete this record", "Student Registration System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    string sql = "DELETE FROM [Table] WHERE Id=" + Convert.ToInt32(cmbmemid.SelectedValue.ToString());
                    SqlCommand cmd = new SqlCommand(sql, coz);
                    coz.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully deleted", "Quiz master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quiz Master",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                coz.Close();
            }
        }

        private void btndeleteupdate_Click(object sender, EventArgs e)
        {
            panel3.Height = pnlupdate.Height;
        }

        private void btnupdatedelete_Click(object sender, EventArgs e)
        {
            panel3.Height = 0;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout ?", "QuizMaster", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 fgh = new Form1();
                fgh.Show();
                this.Hide();
            }
        }
    }
}
