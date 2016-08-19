using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    * This class defines a thank-you form.
    * </summary>
    * 
    * @class StreamScreen
    * @extends Form
    */
    public partial class StreamForm : Form
    {
        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method StreamForm
        */
        public StreamForm()
        {
            InitializeComponent();
        }

        /** <summary>
        * This method ends the program when the OK button is clicked.
        * </summary>
        *
        * @method OKButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /** <summary>
        * This method pulls values from the previous forms to display when the form is activated.
        * </summary>
        *
        * @method StreamForm_Activated
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void StreamForm_Activated(object sender, EventArgs e)
        {
            ChargeLabel.Text = String.Format("Your Credit Card will be charged {0}.", Program.selectionForm.SelectedMovieInfo[3]);
            MovieLabel.Text = String.Format("{0} will begin shortly.", Program.selectionForm.SelectedMovieInfo[4]);
        }
    }
}
