using System;
using System.Collections.Generic;
using System.Linq;
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
    /**<summary>
    * This is the driver class of the program.
    * </summary>
    *
    * @class Program
    */
    public static class Program
    {
        public static SplashScreenForm splashForm;
        public static SelectionForm selectionForm;
        public static OrderForm orderForm;
        public static StreamForm streamForm;
        public static MovieBonanzaAboutBox aboutBox;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        /**<summary>
        * This is the main method.
        * </summary>
        *
        * @method Main
        * @returns {void}
        */
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashScreenForm();
            selectionForm = new SelectionForm();
            orderForm = new OrderForm();
            streamForm = new StreamForm();
            aboutBox = new MovieBonanzaAboutBox();
            Application.Run(splashForm);
        }
    }
}
