using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_White
{
   
public partial class addNewForm : Form
    {
        DeskQuote quote = new DeskQuote();
        Desk desk = new Desk();
        public List<string> listMaterial = new List<string>();
        private EventHandler comboRushDays_SelectedIndexChanged;

        public addNewForm()
        {
            InitializeComponent();

            // Surface Material. Use Enum.
            listMaterial.Insert(0, "Select");
            foreach ( string name in Enum.GetNames(typeof(DesktopMaterial)))
            {
                listMaterial.Add(name);
                comboDeskMaterial.Items.Add(name);
            }

            string[] rushDays = new string[4];
            rushDays[0] = "Normal";
            rushDays[1] = "3 Days";
            rushDays[2] = "5 Days";
            rushDays[3] = "7 Days";

            foreach (string s in rushDays)
            {
                comboRushDays.Items.Add(s);
            }

        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

        private void textWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(textWidth.Text, out errorMsg))
            {
                e.Cancel = true;
                textWidth.Select(0, textWidth.Text.Length);

                // display error.
                this.errorProviderWidth.SetError(textWidth, errorMsg);

            }
        }

        private void textWidth_Validated(object sender, EventArgs e)
        {
            errorProviderWidth.SetError(textWidth, "");
        }

        public bool ValidWidth(string width, out string errorMsg)
        {
            if (width.Length == 0)
            {
                errorMsg = "Width is required.";
                return false;
            }

            if (Convert.ToInt32(width) >= Desk.MIN_WIDTH && Convert.ToInt32(width) <= Desk.MAX_WIDTH) 
            {
                errorMsg = "";
                return true;
            }
            errorMsg = "Width must be between " + Desk.MIN_WIDTH + " in and " + Desk.MAX_WIDTH + " in.";
            return false;
        }

        private void textDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(textDepth.Text, out errorMsg))
            {
                e.Cancel = true;
                textDepth.Select(0, textDepth.Text.Length);

                this.errorProviderDepth.SetError(textDepth, errorMsg);
            }
        }

        private void textDepth_Validated(object sender, EventArgs e)
        {
            errorProviderDepth.SetError(textDepth, "");
        }

        public bool ValidDepth(string  depth, out string errorMsg)
        {
            if (depth.Length == 0)
            {
                errorMsg = "Depth is required.";
                return false;
            }

            if (Convert.ToInt32(depth) >= Desk.MIN_DEPTH && Convert.ToInt32(depth) <= Desk.MAX_DEPTH)
            {
                errorMsg = "";
                return true;
            }
            errorMsg = "Depth range is between " + Desk.MIN_DEPTH + " inches and " + Desk.MAX_DEPTH + " inches.";
            return false;
        }

        private void widthCharValidation(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void depthCharValidation(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addNewForm_Load(object sender, EventArgs e)
        {
            System.Object[] drawers = new System.Object[8];
            for (int i = 0; i < drawers.Length; i++)
            {
                drawers[i] = comboDrawers.Items.Add(i);
                //drawers[i] = i + 1;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }
    }
}
