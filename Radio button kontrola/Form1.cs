using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_button_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRezerviraj_Click(object sender, EventArgs e)
        {
            TxtOdabir.Clear();

            if (RBtnAutobus.Checked)
            {
                TxtOdabir.AppendText("Odabrali ste prijevoz autobusom.");
            }
            if (RBtnAvion.Checked)
            {
                TxtOdabir.AppendText("Odabrali ste prijevoz avionom.");
            }
            if (RBtnVlastiti.Checked)
            {
                TxtOdabir.AppendText("Odabrali ste prijevoz vlastitim vozilom.");
            }
        }
    }
}
