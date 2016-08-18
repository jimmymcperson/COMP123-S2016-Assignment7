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
 * Version: 0.0.4 - Added MoviebonanzaAboutBox and added some event handlers to OrderForm.
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
            MessageBox.Show("Print", "Your order is printing.", MessageBoxButtons.OK);
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

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
