using System;
using MarketLateFeeCalculator;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sonu_LateFeeCalulator;

namespace MarketLateFeeCalculator
{
    public partial class frmmain : Form
    {
        // Creating the instances of the form
        frmLibrarys LibraryGames = new frmLibrarys();
        frmSystems GameSystems = new frmSystems();
        Frmnew NewRelease = new Frmnew();
        frmRentalMaintenance frmRentalMaintenance = new frmRentalMaintenance();
        

        double libraryLateFee=0;
        double newLateFee=0;
        double systemLateFee=0;
        public static string formName;


        public frmmain()
        {
            InitializeComponent();
        }

     
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlibrary_Click(object sender, EventArgs e)
        {
            //creating the tag
            this.Tag = "library";
            formName = Tag.ToString();
            LibraryGames.ShowDialog();
            libraryLateFee = frmLibrarys.lateFee;
            calculateLateFee();
            this.Show();
        }

        private void btnNewReleases_Click(object sender, EventArgs e)
        {
            //creating the tag
            this.Tag = "newRelease";
            formName = Tag.ToString();
            NewRelease.ShowDialog();
            newLateFee = Frmnew.lateFee;
            calculateLateFee();
            this.Show();

        }

        private void btnsystem_Click(object sender, EventArgs e)
        {
            //creating the tag
            this.Tag = "systems";
            formName = Tag.ToString();
            GameSystems.ShowDialog();
            systemLateFee = frmSystems.lateFee;
            calculateLateFee();
            this.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
        private void calculateLateFee()
        {
            double totalLateFee = libraryLateFee + newLateFee + systemLateFee;
            labelTotal.Text = totalLateFee.ToString("c");
           
        }

        private void btnAddNewGame_Click(object sender, EventArgs e)
        {
            frmRentalMaintenance.ShowDialog();
        }
    }
}
