using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void muneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Memumain main = new Memumain();
            main.Show();
        }

        private void เพมพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Employee ade = new Add_Employee();
            ade.Show();
        }

        private void ขอมลพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployee she = new ShowEmployee();
            she.Show();
        }

        private void ผจดการToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
