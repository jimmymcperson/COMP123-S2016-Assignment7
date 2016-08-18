using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * ==================================================================================================
 * App Name: Movie Bonanza App
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: August 17, 2016
 * Description: Movie app work in progress
 * Version: 0.0.4 - Added MoviebonanzaAboutBox and added some event handlers to OrderForm.
 * ==================================================================================================
 */

namespace MovieBonanzaApp
{    
    /** <summary>
    * This class defines an "about" form for the app.
    * </summary>
    * 
    * @class MovieBonanzaAboutBox
    * @extends Form
    */
    public partial class MovieBonanzaAboutBox : Form
    {
        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method MovieBonanzaAboutBox
        */
        public MovieBonanzaAboutBox()
        {
            InitializeComponent();

        }

        /** <summary>
        * This method closes the about window when the OK button is clicked.
        * </summary>
        *
        * @method OkButton_Click
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
