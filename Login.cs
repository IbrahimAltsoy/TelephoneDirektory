using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelephoneDirektory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O97PCTN\SQLEXPRESS;Initial Catalog=TelephoneDirectory;Integrated Security=True");
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar=true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            // username:Altsoy password:1234
            try
            {
                conn.Open();
                string password = "Select * From LOGIN where USERNAME=@p1 AND PASSWORD=@p2";
                SqlParameter prm1 = new SqlParameter("p1", TxtUserName.Text.Trim());
                SqlParameter prm2 = new SqlParameter("p2",TxtPassword.Text.Trim());
                SqlCommand command=new SqlCommand(password,conn);
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);
                DataTable dt=new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    Directory form = new Directory();
                    form.Show();
                    


                }              


            }
            catch (Exception)
            {

                MessageBox.Show("You entered wrong!!!");
                TxtUserName.Text = "";
                TxtPassword.Text = "";
            }
        }
    }
}
