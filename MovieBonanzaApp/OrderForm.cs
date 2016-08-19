using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * ==================================================================================================
 * App Name: Movie Bonanza App
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Created: August 19, 2016
 * Description: This app streams movies to your device.  It also allows you to order movies.
 * Version: 0.1.0 - Completed program.
 * ==================================================================================================
 */
namespace MovieBonanzaApp
{
    /** <summary>
    * This class defines a form where the user orders their selected movie.
    * </summary>
    * 
    * @class OrderForm
    * @extends Form
    */
    public partial class OrderForm : Form
    {
        // FIELDS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method OrderForm
        */
        public OrderForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This method closes the current form and shows the previous form when any
        * cancel button is clicked.
        * </summary>
        *
        * @method Cancel_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.selectionForm.Show();
        }

        /** <summary>
        * This method sends the user to the StreamForm when any stream button is clicked.
        * </summary>
        *
        * @method Stream_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void Stream_Click(object sender, EventArgs e)
        {
            // store values in list for use
            Program.selectionForm.SelectedMovieInfo.Add(GrandTotalTextBox.Text);
            Program.selectionForm.SelectedMovieInfo.Add(MovieSelectedTitleTextBox.Text);

            this.Hide();
            Program.streamForm.Show();
        }

        /** <summary>
        * This method displays a message that confirms that the user wishes to print the order.
        * </summary>
        *
        * @method Print_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is printing.", "Print", MessageBoxButtons.OK);
        }

        /** <summary>
        * This method displays information about this program when any about button is clicked.
        * </summary>
        *
        * @method About_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void About_Click(object sender, EventArgs e)
        {
            Program.aboutBox.Show();
        }

        /** <summary>
        * This method displays information about selected movie when activated.
        * </summary>
        *
        * @method OrderForm_Activated
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            MovieSelectedTitleTextBox.Text = Program.selectionForm.SelectedMovieInfo[0];
            MovieSelectedCategoryTextBox.Text = Program.selectionForm.SelectedMovieInfo[1];
            this.GetMovieImage(Program.selectionForm.SelectedMovieInfo[0]);
            CalculateCosts();

        }

        /** <summary>
        * This method calculates and displays the costs associated with a movie.
        * </summary>
        *
        * @method CalculateCosts
        * @private
        * @returns {void}
        */
        private void CalculateCosts()
        {
            //values are retrieved from selectionForm's SelectedMovieInfo field for calculations
            CostTextBox.Text = String.Format("{0:c}" , Program.selectionForm.SelectedMovieInfo[2]);
            SubtotalTextBox.Text = String.Format("{0:c}" , ((Convert.ToDouble(Program.selectionForm.SelectedMovieInfo[2])) + (Convert.ToDouble(AdditionalChargeTextBox.Text.Remove(0, 1)))));
            SalesTaxTextBox.Text = String.Format("{0:c}" , (((Convert.ToDouble(Program.selectionForm.SelectedMovieInfo[2])) + (Convert.ToDouble(AdditionalChargeTextBox.Text.Remove(0, 1)))) * 0.13));
            GrandTotalTextBox.Text = String.Format("{0:c}", (((Convert.ToDouble(Program.selectionForm.SelectedMovieInfo[2])) + (Convert.ToDouble(AdditionalChargeTextBox.Text.Remove(0, 1)))) * 1.13));
        }

        /** <summary>
        * This method changes the picture in MovieSelectedPictureBox depending on
        * the parameter "movie".
        * </summary>
        *
        * @method GetMovieImage
        * @params {string} movie
        * @private
        * @returns {void}
        */
        private void GetMovieImage(string movie)
        {
            if (movie.Equals("Cedar Rapids"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.cedarrapids;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Company Men"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.companymen;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Death Race 2"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.deathrace2;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Footloose"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.footloose;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Gnomeo and Juliet"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.gnomeoandjuliet;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("I am Number Four"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.iamnumberfour;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Just Go With It"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.justgowithit;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("No Strings Attached"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.nostringsattached;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Real Steel"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.realsteel;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Sanctum"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.sanctum;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Season of the Witch"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.seasonofthewitch;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Dilemma"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.thedilemma;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Eagle"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.theeagle;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Green Hornet"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.thegreenhornet;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Mechanic"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.themechanic;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Other Woman"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.theotherwoman;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Rite"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.therite;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Roommate"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.theroommate;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("The Way Back"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.thewayback;
                MovieSelectedPictureBox.Refresh();
            }
            else if (movie.Equals("Waiting for Forever"))
            {
                MovieSelectedPictureBox.Image = Properties.Resources.waitingforever;
                MovieSelectedPictureBox.Refresh();
            }
            else
            {
                MovieSelectedPictureBox.Image = null;
            }
        }

        /** <summary>
        * This method displays an additional fee if checked.
        * </summary>
        *
        * @method ShipDVDCheckBox_CheckedChanged
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void ShipDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShipDVDCheckBox.Checked == false)
            {
                AdditionalChargeTextBox.Text = "$0.00";
                AdditionalChargeTextBox.Hide();
                AdditionalChargeLabel.Hide();
            }
            else
            {
                AdditionalChargeTextBox.Text = "$10.00";
                AdditionalChargeTextBox.Show();
                AdditionalChargeLabel.Show();
            }
            CalculateCosts();
        }

        /** <summary>
        * This method hides the current form and shows the previous 
        * form when the back button is clicked.
        * </summary>
        * @method BackButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */ 
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectionForm.Show();
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
