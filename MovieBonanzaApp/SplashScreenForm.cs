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
    * This class defines a form for a splash screen.
    * </summary>
    * 
    * @class SplashScreenForm
    * @extends Form
    */
    public partial class SplashScreenForm : Form
    {
        /** <summary>
        * This is the default constructor.
        * </summary>
        *
        * @method SplashScreenForm
        */
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
        }
    }
}
