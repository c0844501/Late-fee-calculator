using System;
using System.Collections;
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
    public partial class frmLateGames : Form
    {
        SortedList<int, string> listLibrary = new SortedList<int, string>();
        SortedList<int, string> listNew = new SortedList<int, string>();
        SortedList<int, string> listSystems = new SortedList<int, string>();
        public static int libraryCount=0;
        public static int newCount = 1;
        public static int systemCount = 1;
        public static int countsystem;
        public static int countnew;
        public static int countlibrary;
       

        public frmLateGames()
        {
            InitializeComponent();
        }




        private void btnAddGame_Click(object sender, EventArgs e)
        {
            //action based on "Library" tag name in the main form

            if (MarketLateFeeCalculator.frmmain.formName == "library")
            {
                if (txtLateGame.Text == "")
                {
                    //Error message
                    MessageBox.Show("Enter the name of late games");
                }
                else
                {
                    //Add the games to the library list
                    listLibrary.Add(libraryCount, this.txtLateGame.Text);
                   //counter variable to count the no of games
                    libraryCount++;
                    countlibrary = listLibrary.Count;
                    this.txtLateGame.Text = "";
                    txtLateGame.Focus();
                    this.Show();
                }
            }
            //action based on "newRelease" tag name in the main form
            else if (MarketLateFeeCalculator.frmmain.formName == "newRelease")
            {
                if (txtLateGame.Text == "")
                {
                    //Error message
                    MessageBox.Show("Enter the late games");
                }
                else
                {
                    //Add the games to the new release list
                    listNew.Add(newCount, this.txtLateGame.Text);
                    //counter variable to count the no of games
                    newCount++;
                    countnew = listNew.Count;
                    this.txtLateGame.Text = "";
                    txtLateGame.Focus();
                    this.Show();
                }
            }
            //action based on "systems" tag name in the main form
            else if (MarketLateFeeCalculator.frmmain.formName == "systems")
            {
                if (txtLateGame.Text == "")
                {
                    //Error message
                    MessageBox.Show("Enter the name of late games");
                }
                else
                {
                    //Adding data to system sorted list
                    listSystems.Add(systemCount, this.txtLateGame.Text);
                    //counter variable to count the no of games
                    systemCount++;
                    countsystem = listSystems.Count;
                    this.txtLateGame.Text = "";
                    txtLateGame.Focus();
                    this.Show();

                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
