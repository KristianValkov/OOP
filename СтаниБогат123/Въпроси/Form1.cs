using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Въпроси
{
    public partial class Form1 : Form
    {
        ////1 step
        //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users" +
        //    "\\STUDENTS-STEM-12\\AppData\\Local\\Quiz- 11a.mdf\";Integrated Security=True;Connect Timeout=30";
        //SqlConnection connect = new SqlConnection(connectionString);
        //connect.Open();
        //MessageBox.Show("Добре е");
        ////2 step
        //string strinqQuery = "Select * from Questions";
        //SqlCommand cmd = new SqlCommand(strinqQuery, sc);
        ////3 step
        //SqlDataReader reader = cmd.ExecuteReader();
        ////4 step REad the reader
        //while (reader.Read())
        //{
        //    lblA.Text = reader["A1"].ToString();
        //}
        //// step Closes
        //reader.Close();
        //connectionString.Close();
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users" +
            "\\STUDENTS-STEM-12\\AppData\\Local\\Quiz- 11a.mdf\";Integrated Security=True;Connect Timeout=30";
        SqlConnection c;
        SqlCommand command;
        SqlDataReader r;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c = new SqlConnection(connectionString);
            if(c.State==0)
            {
                c.Open();
            }
            string textQuery = "Select*from Qustions";
            command = new SqlCommand(textQuery, c);
            r=command.ExecuteReader();
            LoadQ();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadQ()
        {
            if(r.Read())
            {
                r.Close();
                c.Close();
            }
            r.Read();
            lblQ.Text = r["Question"].ToString();
            lblA.Text = r["Answer1"].ToString();
            lblB.Text = r[3].ToString();
            lblC.Text = r["Answer3"].ToString();
            lblD.Text = r["Answer4"].ToString();
        }
        private void lblD_Click(object sender, EventArgs e)
        {
            if(string.Compare(lblD.Text, r["Correct"].ToString())==0)//lblD.Text == r["Correct"].ToString()
            {
                MessageBox.Show("Vqrno!");
                lblD.BackColor = Color.Green;
                lblD.ForeColor=Color.White;
                ClearSccreen();
                LoadQ();
            }
            else
            {
                lblD.BackColor = Color.Red;
                lblD.ForeColor = Color.White;
                DialogResult button=
                MessageBox.Show("Greshno!","Begin?",MessageBoxButtons.YesNo);
                if(button==DialogResult.Yes)
                {
                    r = command.ExecuteReader();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void ClearSccreen()
        {
            lblA.BackColor= SystemColors.ControlText;
            lblA.ForeColor = Color.DarkGreen;
            lblB.BackColor = SystemColors.ControlText;
            lblB.ForeColor = Color.DarkGreen;
            lblC.BackColor = SystemColors.ControlText;
            lblC.ForeColor = Color.DarkGreen;
            lblD.BackColor = SystemColors.ControlText;
            lblD.ForeColor = Color.DarkGreen;
        }
        private void lblB_Click(object sender, EventArgs e)
        {
            if (string.Compare(lblB.Text, r["Correct"].ToString()) == 0)//lblD.Text == r["Correct"].ToString()
            {
                MessageBox.Show("Vqrno!");
                lblB.BackColor = Color.Green;
                lblB.ForeColor = Color.White;
                ClearSccreen();
                LoadQ();
            }
            else
            {
                lblB.BackColor = Color.Red;
                lblB.ForeColor = Color.White;
                DialogResult button=
                MessageBox.Show("Greshno!", "Begin?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    r = command.ExecuteReader();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void lblC_Click(object sender, EventArgs e)
        {
            if (string.Compare(lblC.Text, r["Correct"].ToString()) == 0)//lblD.Text == r["Correct"].ToString()
            {
                MessageBox.Show("Vqrno!");
                lblC.BackColor = Color.Green;
                lblC.ForeColor = Color.White;
                ClearSccreen();
                LoadQ();
            }
            else
            {
                lblC.BackColor = Color.Red;
                lblC.ForeColor = Color.White;
                DialogResult button =
                MessageBox.Show("Greshno!", "Begin?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    r = command.ExecuteReader();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void lblA_Click(object sender, EventArgs e)
        {
            if (string.Compare(lblA.Text, r["Correct"].ToString()) == 0)//lblD.Text == r["Correct"].ToString()
            {
                MessageBox.Show("Vqrno!");
                lblA.BackColor = Color.Green;
                lblA.ForeColor = Color.White;
                ClearSccreen();
                LoadQ();
            }
            else
            {
                lblA.BackColor = Color.Red;
                lblA.ForeColor = Color.White;
                DialogResult button =
                MessageBox.Show("Greshno!", "Begin?", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    r = command.ExecuteReader();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
;