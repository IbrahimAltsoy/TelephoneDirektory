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
using System.Xml.Linq;


namespace TelephoneDirektory
{
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O97PCTN\SQLEXPRESS;Initial Catalog=TelephoneDirectory;Integrated Security=True");
        void Tolist()
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da=new SqlDataAdapter("Select * from PERSON",conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Clear();

        }
        void Clear()
        {
            TxtId.Text = "";
            txtName.Text = "";
            TxtSurname.Text = "";
            txtCareer.Text = "";
            TxtMail.Text = "";
            TxtAdress.Text = "";
            MskTelephone.Text = "";
            txtName.Focus();
        }

        private void GrbxUser_Enter(object sender, EventArgs e)
        {

        }

        private void Directory_Load(object sender, EventArgs e)
        {

            Tolist();
            
           
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into PERSON (NAME, SURNAME, CAREER, TELEPHONE, MAIL, ADRESS) values (@p1,@p2,@p3,@p4,@p5,@P6)", conn);
           
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", txtCareer.Text);
            command.Parameters.AddWithValue("@p4", MskTelephone.Text);
            command.Parameters.AddWithValue("@p5", TxtMail.Text);
            command.Parameters.AddWithValue("@p6", TxtAdress.Text);

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added to the system");
            Tolist();
            Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[choose ].Cells[2].Value.ToString();
            txtCareer.Text = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            MskTelephone.Text = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[choose ].Cells[5].Value.ToString();
            TxtAdress.Text=dataGridView1.Rows[choose ].Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void GrbxProcedures_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var yousure = MessageBox.Show("Are you sure you want to delete the contact's information?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ;
            if (yousure == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From PERSON where ID=" + TxtId.Text, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("The contact has been deleted from the person","Information" ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
               
                Tolist();
                Clear();

            }
            else
            {
                Clear();
            }
            
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var yousure = MessageBox.Show("Are you sure you want to update the contact's information?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (yousure==DialogResult.Yes)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("update PERSON set NAME=@p1, SURNAME=@p2, CAREER=@p3, TELEPHONE=@p4, MAIL=@p5, ADRESS=@p6 WHERE ID=@p7", conn);

                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.Parameters.AddWithValue("@p2", TxtSurname.Text);
                command.Parameters.AddWithValue("@p3", txtCareer.Text);
                command.Parameters.AddWithValue("@p4", MskTelephone.Text);
                command.Parameters.AddWithValue("@p5", TxtMail.Text);
                command.Parameters.AddWithValue("@p6", TxtAdress.Text);
                command.Parameters.AddWithValue("@p7", TxtId.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("The contact has been update from the person", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Tolist();
                Clear();
            }
            else
            {
                Clear();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
