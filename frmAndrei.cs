using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevPanel
{
    public partial class frmAndrei : Form
    {
        frmMain mainForm;

        public frmAndrei()
        {
            InitializeComponent();

            //mainForm = (frmMain)this.Owner;
        }

        private void frmAndrei_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void frmAndrei_Load(object sender, EventArgs e)
        {
            mainForm = (frmMain)this.Owner;

        }
    }
}
