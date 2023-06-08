using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Quizmaster
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());

        public static Form1 instance;
      
        public Label lab1;
        double val = 0;

        public Form1()
        {
            InitializeComponent();
            instance= this;
            
            AutoID();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnewaccount_Click(object sender, EventArgs e)
        {


        }

        private void btnnewaccount_Click_1(object sender, EventArgs e)
        {
            pnlregister.Height = pnl2.Height;

        }

        private void btnbacklog_Click(object sender, EventArgs e)
        {
            pnlregister.Height = 0;
            pnl2.Location = new Point(315, 5);

        }

        private void btnregister_Click(object sender, EventArgs e)
        {


            try
            {
                string regdate = dtpbirthday.Value.ToString("yyyy-MM-dd");


                string sql = "INSERT INTO [Table]  (ID,UserName,NIC,Password,Confirmpassword,Birthdate) VALUES (" + txtid.Text + ",'" + txtusernamereg.Text + "', '" + txtemail.Text + "', '" + txtpasswordreg.Text + "', " + txtconfirmpassword.Text + ",'" + regdate + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Registration Successful ", "Quiz Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quiz Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
               string query = "Select * from [Table] Where UserName = '" + txtusernamelogin.Text.Trim() + "' and Password =  '" + txtpasswordlogin.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    Form2 objform = new Form2();
                    this.Hide();
                    objform.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect username or password.Try again");
                }

            Form2.instance.lab1.Text = txtusernamelogin.Text;
             
            
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            String passwordadmin, usernameadmin;

            passwordadmin = "Admin1234";
            usernameadmin = "Admin";

            if (passwordadmin == txtpasswordlogin.Text && usernameadmin == txtusernamelogin.Text)
            {
                Admin xcv = new Admin();
                xcv.Show();
                this.Hide();
            }
        }

        private void AutoID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [ID] FROM [Table] ORDER BY [ID] DESC", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            txtid.Text =  val + i.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GPS  x = new GPS();
            x.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtusernamelogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpasswordlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlregister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

