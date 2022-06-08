using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form activeFrom = null;
        private void openChildFrom(Form ChildFrom)

        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            activeFrom = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            frm_ch.Controls.Add(ChildFrom);
            frm_ch.Tag = ChildFrom;
            ChildFrom.BringToFront();
            ChildFrom.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFrom(new emp());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFrom(new Form2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFrom(new Form3());
        }
    }
}
