using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TSM_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is testing Windows Form program. Author: Karim Guzairov","About this program");
        }

        private void TSM_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
