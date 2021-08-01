using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_modern_flat_UI_design_dashboard.Forms
{
    public partial class Formnotification : Form
    {
        public Formnotification()
        {
            InitializeComponent();

        }

        private void Formnotification_Load(object sender, EventArgs e)
        {
            loadtheme();
        }
        private void loadtheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton)btns;
                    //btns.BackColor = Themecolor.primarycolor;
                    btns.ForeColor = Color.Black;
                    // btn.FlatAppearance.BorderColor = Themecolor.secondarycolor;

                }
            }
           // labelnotification.ForeColor = Themecolor.secondarycolor;
            // label5.ForeColor = Themecolor.primarycolor;
        }
    }
}
