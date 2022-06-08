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

namespace _1
{
    public partial class emp : Form
    {

         static SqlConnection commm = new SqlConnection("data source = *********; initial catalog = emp;");
        static SqlCommand commadn = new SqlCommand();
        public emp()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Mysql = "inset into Users (ID,user)value('"+textBox1.Text+"','"+textBox2.Text+"' ";
            commm.Open();
            commadn.CommandText = Mysql;
            commadn.Connection = commm;
            commm.Close();

            MessageBox.Show("ok add");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Mysql = "update Users set user='" + textBox2.Text + "'where ID=" + textBox1;
            commm.Open();
            commadn.CommandText = Mysql;
            commadn.Connection = commm;
            commm.Close();

            MessageBox.Show("ok update");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Mysql = "Delete Users where ID=" + textBox1;
            commm.Open();
            commadn.CommandText = Mysql;
            commadn.Connection = commm;
            commm.Close();

            MessageBox.Show("ok del");
        }
    }
}
