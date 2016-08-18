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
 * Date Modified: August 17, 2016
 * Description: Movie app work in progress
 * Version: 0.0.3 - Added functionality to SelectionForm.
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
            Application.Run(splashForm);
        }
    }
}
