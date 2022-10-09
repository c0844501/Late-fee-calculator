using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonu_LateFeeCalulator
{
    public partial class frmRentalMaintenance : Form
    {
        //instance for the form
        frmNewGame frmNewGame=new frmNewGame();
        public frmRentalMaintenance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmNewGame.ShowDialog(this);
        }
    }
}
