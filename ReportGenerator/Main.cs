using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGenerator
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

        private void шаблон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Template1 t1 = new Template1();
            t1.ShowDialog();
        }

        private void шаблон1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Template2 t2 = new Template2();
            t2.ShowDialog();
        }

        private void шаблон1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Template3 t3 = new Template3();
            t3.ShowDialog();
        }

        private void шаблон10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Template10 t10 = new Template10();
            t10.ShowDialog();
        }
    
    }
}
