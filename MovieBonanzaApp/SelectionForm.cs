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
 * Date Modified: August 17, 2016
 * Description: Movie app work in progress
 * Version: 0.0.5 - Added functionality to OrderForm (excluding back/stream buttons).
 * ==================================================================================================
 */
namespace MovieBonanzaApp
{
    /** <summary>
    * This class defines a form where the user selects a movie.
    * </summary>
    * 
    * @class SelectionForm
    * @extends Form
    */
    public partial class SelectionForm : Form
    {
        // FIELDS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        List<string> _selectedMovieInfo = new List<string> { }; //stores the info of the user's selected movie

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This property read/writes the _selectedMovieInfo property.
        * </summary>
        *
        * @property SelectedMovieInfo
        */
        public List<string> SelectedMovieInfo
        {
            get
            {
                return _selectedMovieInfo;
            }

            set
            {
                _selectedMovieInfo = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method SelectionForm
        */
        public SelectionForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This method changes the display and stores data in SelectedMovieInfo when the SelectedValue of
        * MovieDropDownList is changed.
        * </summary>
        *
        * @method MovieDropDownList_SelectedValueChanged
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void MovieDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedMovieInfo.Clear();
            UpdateYourSelectionGroupBox();
            SelectedMovieInfo.Add(MovieTitleTextBox.Text);
            SelectedMovieInfo.Add(MovieCategoryTextBox.Text);
            SelectedMovieInfo.Add(MovieCostTextBox.Text.Remove(0,1));
            if (!(SelectedMovieInfo.Contains("")))
            {
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        /** <summary>
        * This button hides SelectionForm and displays OrderForm when clicked.
        * </summary>
        *
        * @method NextButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // try-catch is to account for the case where OrderForm is closed (by the cancel button)
            try
            {
                Program.orderForm.Show();
            }
            catch
            {
                Program.orderForm = new OrderForm();
                Program.orderForm.Show();
            } 
        }

        /** <summary>
        * This method changes the display in YourSelectionGroupBox.
        * </summary>
        *
        * @method UpdateYourSelectionGroupBox
        * @private
        * @returns {void}
        */
        private void UpdateYourSelectionGroupBox()
        {
            if (!(MovieDropDownList.SelectedItem.ToString()).Equals("")) //fires if a movie is considered "selected"
            {
                MovieTitleTextBox.Text = (MovieDropDownList.SelectedItem.ToString());
                MovieCategoryTextBox.Text = (GetMovieCategory(MovieDropDownList.SelectedItem.ToString()));
                MovieCostTextBox.Text = String.Format("$" +(GetCategoryCost(MovieCategoryTextBox.Text)));
                this.GetMovieImage(MovieDropDownList.SelectedItem.ToString());
            }
            else //fires when there is no movie selected
            {
                MovieTitleTextBox.Text = "";
                MovieCategoryTextBox.Text = "";
                MovieCostTextBox.Text = "";
            }
        }

        /** <summary>
        * This method returns a string depending on the parameter "movie".
        * </summary>
        *
        * @method GetMovieCategory
        * @params {string} movie
        * @private
        * @returns {string}
        */
        private string GetMovieCategory(string movie)
        {
            if (movie.Equals("Cedar Rapids"))
            {
                return "Comedy";
            }
            else if (movie.Equals("Company Men"))
            {
                return "Drama";
            }
            else if (movie.Equals("Death Race 2"))
            {
                return "Action";
            }
            else if (movie.Equals("Footloose"))
            {
                return "New Release";
            }
            else if (movie.Equals("Gnomeo and Juliet"))
            {
                return "Family";
            }
            else if (movie.Equals("I am Number Four"))
            {
                return "Sci-Fi";
            }
            else if (movie.Equals("Just Go With It"))
            {
                return "Comedy";
            }
            else if (movie.Equals("No Strings Attached"))
            {
                return "Comedy";
            }
            else if (movie.Equals("Real Steel"))
            {
                return "New Release";
            }
            else if (movie.Equals("Sanctum"))
            {
                return "Action";
            }
            else if (movie.Equals("Season of the Witch"))
            {
                return "Sci-Fi";
            }
            else if (movie.Equals("The Dilemma"))
            {
                return "Comedy";
            }
            else if (movie.Equals("The Eagle"))
            {
                return "Action";
            }
            else if (movie.Equals("The Green Hornet"))
            {
                return "Action";
            }
            else if (movie.Equals("The Mechanic"))
            {
                return "Action";
            }
            else if (movie.Equals("The Other Woman"))
            {
                return "Action";
            }
            else if (movie.Equals("The Rite"))
            {
                return "Horror";
            }
            else if (movie.Equals("The Roommate"))
            {
                return "Thriller";
            }
            else if (movie.Equals("The Way Back"))
            {
                return "Drama";
            }
            else if (movie.Equals("Waiting for Forever"))
            {
                return "Drama";
            }
            else
            {
                return "";
            }
        }

        /** <summary>
        * This method returns a string depending on the parameter "category".
        * </summary>
        *
        * @method GetCategoryCost
        * @params {string} category
        * @private
        * @returns {string}
        */
        private string GetCategoryCost(string category)
        {
            if (category == "Comedy" || category == "Drama" || category == "Thriller")
            {
                return "1.99";
            }
            else if (category == "Action" || category == "Sci-Fi" || category == "Horror")
            {
                return "2.99";
            }
            else if (category == "Family")
            {
                return "0.99";
            }
            else if (category == "New Release")
            {
                return "4.99";
            }
            else
            {
                return "";
            }
        }

        /** <summary>
        * This method changes the picture in MovieCoverPictureBox depending on
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
                MovieCoverPictureBox.Image = Properties.Resources.cedarrapids;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Company Men"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.companymen;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Death Race 2"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.deathrace2;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Footloose"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.footloose;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Gnomeo and Juliet"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.gnomeoandjuliet;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("I am Number Four"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.iamnumberfour;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Just Go With It"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.justgowithit;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("No Strings Attached"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.nostringsattached;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Real Steel"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.realsteel;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Sanctum"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.sanctum;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Season of the Witch"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.seasonofthewitch;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Dilemma"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.thedilemma;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Eagle"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.theeagle;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Green Hornet"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.thegreenhornet;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Mechanic"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.themechanic;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Other Woman"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.theotherwoman;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Rite"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.therite;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Roommate"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.theroommate;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("The Way Back"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.thewayback;
                MovieCoverPictureBox.Refresh();
            }
            else if (movie.Equals("Waiting for Forever"))
            {
                MovieCoverPictureBox.Image = Properties.Resources.waitingforever;
                MovieCoverPictureBox.Refresh();
            }
            else
            {
                MovieCoverPictureBox.Image = null;
            }
        }


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
