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
 * Date Modified: August 17, 2016
 * Description: Movie app work in progress
 * Version: 0.0.2 - Constructed forms and layouts.
 * ==================================================================================================
 */

namespace MovieBonanzaApp
{
    /** <summary>
    * This class defines a form for a splash screen.
    * </summary>
    * 
    * @class SplashScreen
    * @extends Form
    */
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        /** <summary>
        * This method closes the form after 3 seconds.
        * </summary>
        *
        * @method SplashScreenTimer_Tick
        * @params {object} sender
        * @params {EventArgs} e
        * @private
        * @returns {void}
        */
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            this.Hide();
            Program.selectionForm.Show();
            Program.orderForm.Show();
            Program.streamForm.Show();
        }
    }
}
