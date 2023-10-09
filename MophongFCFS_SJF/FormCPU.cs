using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MophongFCFS_SJF
{
    public partial class FormCPU : Form
    {
        public FormCPU()
        {
            InitializeComponent();
        }

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            FormFCFS fcfs = new FormFCFS();
            this.Hide();
            fcfs.ShowDialog();
            this.Show();
        }


        private void btnSJF_Click(object sender, EventArgs e)
        {
            FormSJF sjf = new FormSJF();
            this.Hide();
            sjf.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

    }
}
