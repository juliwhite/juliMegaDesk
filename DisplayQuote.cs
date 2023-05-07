using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_White
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();

            // Set current date.
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            labelDate.Text = currentDate.ToString("MM/dd/yyyy");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            addNewForm viewDisplayQuote = (addNewForm)Tag;
            viewDisplayQuote.Show();
            Close();
        }
    }

    internal class AddNewForm
    {
    }
}
