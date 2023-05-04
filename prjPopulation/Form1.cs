using System.ComponentModel.DataAnnotations;

namespace prjPopulation
{
    public partial class frmPopulation : Form
    {
        public frmPopulation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all of the text boxes
            txtCity.Text = null;
            txtNewPop.Text = null;
            txtOldPop.Text = null;
            txtState.Text = null;
            txtPercentIncrease.Text = null;
            txtPercentDecrease.Text = null;

            //Set focus to the city text
            txtOldPop.Focus();
            txtOldPop.SelectAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 

            try
            {
                //Create Variables
                string strCity = txtCity.Text;
                string strState = txtState.Text;
                double dblNew = double.Parse(txtNewPop.Text);
                double dblOld = double.Parse(txtOldPop.Text);
                double dblpop;

                //Make state text capitolized
                strState = strState.ToUpper();

                //If New and Old populations value is negative then do something
                if (dblNew < 0 || dblOld < 0)
                {
                    //If the values are negative then show error message 
                    MessageBox.Show("Please Enter a Positive Number");

                    //Set focus back to Old Population and select all
                    txtOldPop.Focus();
                    txtOldPop.SelectAll();
                }
                //Do stuff if New Population is higher than old population
                else if (dblNew > dblOld)
                {
                    //Do the math
                    dblpop = (dblNew - dblOld) / dblOld;

                    //String population to the increasetext
                    txtPercentIncrease.Text = dblpop.ToString("P");
                    
                    //Clear anything that could be in th decrease value
                    txtPercentDecrease.Text = null;

                    //Show pop up message
                    MessageBox.Show("Increase In Population For" + " " + strCity + ", " + strState);

                    //Set focus back to OldPop
                    txtOldPop.Focus();
                }
                //Do stuff if Old Population is higher than New Population
                else if (dblNew < dblOld)
                {
                    //Do the math
                    dblpop = (dblOld - dblNew) / dblOld;

                    //String population to the Decreasetext
                    txtPercentDecrease.Text = dblpop.ToString("P");

                    //Clear anything that could be in th Increase value
                    txtPercentIncrease.Text = null;

                    //Show pop up message
                    MessageBox.Show("Decrease In Population For" + " " + strCity + ", " + strState);

                    //Set focus back to OldPop
                    txtOldPop.Focus();
                }
            }
            catch 
            {
                //Show error when non numeric data is entered in for population
                MessageBox.Show("Please Type Numbers");
            }
        }
    }
}