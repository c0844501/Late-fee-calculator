using Sonu_LateFeeCalulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketLateFeeCalculator
{
    public partial class frmLibrarys : Form
    {
        //class variables
        int numberOfGames = 0;
        int totalGames = 0;
        double customerBreak;
        public static double lateFee;
        public frmLibrarys()
        {
            InitializeComponent();
            // populate Today’s date and show it in the textbox 
            txtcurrentdate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

    

        private void btnreturn_Click(object sender, EventArgs e)
        {
            //resetting the values
            txtCustomerType.Text = "";
            txtlatefee.Text = "";
            txtdayslate.Text = "";
            txtduedate.Text = "";
            //Hide the form
            this.Hide();
        }
        //Validation checks
        public bool IsPresent(TextBox txtduedate, TextBox txtCustomerType, string name, string name2)
        {
            if (txtduedate.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                txtduedate.Focus();
                return false;
            }

            else if (txtCustomerType.Text == "")
            {
                MessageBox.Show(name2 + " is a required field.", "Entry Error");
                txtCustomerType.Focus();
                return false;
            }
            return true;
        }

        //Date entry validation checks
        public static bool IsDateTime(TextBox txtduedate, string name)
        {
            DateTime dueDate;
            if (DateTime.TryParse(txtduedate.Text, out dueDate))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a date.", "Entry Error");
                txtduedate.Focus();
                return false;
            }
        }

        public static bool IsPast(TextBox txtduedate, DateTime dDue, DateTime dCurrent, string name)
        {
            if (dDue > dCurrent)
            {
                MessageBox.Show(name + " must be a past date.", "Entry Error");
                txtduedate.Focus();
                return false;
            }
            return true;
        }
        //customer type entry validation checks
        public static bool IsCustType(TextBox txtCustomerType, string customerType)
        {
            if (!(txtCustomerType.Text == "N" || txtCustomerType.Text == "J" || txtCustomerType.Text == "L"))
            {
                MessageBox.Show(customerType + " must be a valid type.", "Entry Error");
                txtCustomerType.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Data validation checks
        public bool IsValidData()
        {
            return
                IsPresent(txtduedate, txtCustomerType, "Due Date", "Customer Type") &&
                IsDateTime(txtduedate, "Due Date") &&
                IsPast(txtduedate, DateTime.Parse(txtduedate.Text), DateTime.Now, "Due Date") &&
                IsCustType(txtCustomerType, "Customer Type");
        }

        private void CalculateLateFee()
        {
            try
            {
                //Creating instances for form late games
                Form lategames = new Sonu_LateFeeCalulator.frmLateGames();
                DialogResult selectedButton = lategames.ShowDialog();
                if (selectedButton == DialogResult.OK)
                {
                    //Retrieving Number of games from late games form
                    txtTotalGames.Text = (Sonu_LateFeeCalulator.frmLateGames.countlibrary).ToString();

                }
                if (IsValidData())
                {

                    // Generate the current date and stored in the variable in date type
                    DateTime dCurrent = DateTime.Now;
                    // Generate the due date based on user entry in textbox 
                    DateTime dDue = DateTime.Parse(txtduedate.Text);
                    // Calculate the number of days late
                    TimeSpan days = (dCurrent.Date - dDue.Date);
                    double numberOfDays = days.TotalDays;
                    // Display the number of days late in the textbox 
                    txtdayslate.Text = numberOfDays.ToString();

                    numberOfGames = frmLateGames.countlibrary;
                    totalGames = numberOfGames;
                    txtTotalGames.Text = totalGames.ToString();


                    string customerType = Convert.ToString(txtCustomerType.Text);

                    //action based on customer type
                    switch (customerType)
                    {
                        case "N":
                            customerBreak = 0;
                            lateFee = 0.77 * numberOfDays * numberOfGames;
                            lateFee -= (lateFee * customerBreak / 100);
                            txtlatefee.Text = lateFee.ToString("c");
                            break;

                        case "L":
                            customerBreak = 12;
                            lateFee = 0.77 * numberOfDays * numberOfGames;
                            lateFee -= (lateFee * customerBreak / 100);
                            txtlatefee.Text = lateFee.ToString("c");
                            break;

                        case "J":
                            customerBreak = 7;
                            lateFee = 0.77 * numberOfDays * numberOfGames;
                            lateFee -= (lateFee * customerBreak / 100);
                            txtlatefee.Text = lateFee.ToString("c");
                            break;

                        default:
                            lateFee = 0.77 * numberOfDays * numberOfGames;
                            txtlatefee.Text = lateFee.ToString("c");
                            break;

                    }
                    btnreturn.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");

            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateLateFee();

        }

        private void txtNumOfGames_TextChanged(object sender, EventArgs e)
        {
            txtlatefee.Clear();
        }




    }
}
