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
    public partial class frmMain : Form
    {
        private frmAndrei frmAS;

        //private frmAndrei FrmAS {
        //    get {
        //        if (_frmAS == null)
        //        {
        //            _frmAS = new frmAndrei();
        //            _frmAS.Owner = this;
        //        }

        //        return _frmAS;
        //    }
        //}

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAndrei_Click(object sender, EventArgs e)
        {
            frmAS = new frmAndrei();
            frmAS.Owner = this;
            frmAS.Show();
            this.Hide();
        }

        private void btnElisabeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nu cunosc!");
        }

        private void btnFlorin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parca-l stiu ...");
        }
    }
}
