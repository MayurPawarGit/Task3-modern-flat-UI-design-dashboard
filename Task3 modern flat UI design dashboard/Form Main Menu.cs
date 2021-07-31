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

namespace Task3_modern_flat_UI_design_dashboard
{
    public partial class Form_Main_Menu : Form
    {
        private IconButton currentbtn;
        private Random random;
        private int temp;
        private Form activeform;
        public Form_Main_Menu()
        {
            InitializeComponent();
            random = new Random();
           
        }
        //method
        private Color selectthemecolor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (temp == index)
            {
               index= random.Next(Themecolor.ColorList.Count);
            }
            temp = index;
            string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void activeiconbutton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentbtn != (IconButton)btnsender)
                {
                    disablebtn();
                    Color color = selectthemecolor();
                    currentbtn = (IconButton)btnsender;
                    currentbtn.BackColor = color;
                    currentbtn.ForeColor = Color.White;
                    paneltitlebar.BackColor = color;
                    
                }
            }
        }
        private void disablebtn()
        {
            foreach (Control prevbtn in panelmenu.Controls)
            {
                if (prevbtn.GetType() == typeof(IconButton))
                {
                    prevbtn.BackColor = Color.Teal;
                    prevbtn.ForeColor = Color.Black;
                }
            }
        }

        private void openchildform(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeiconbutton(btnsender);
            activeform= childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneldesktoppanel.Controls.Add(childform);
            this.paneldesktoppanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labelhome.Text = childform.Text;

        }

        private void iconbtnproducts_Click(object sender, EventArgs e)
        {
           // activeiconbutton(sender);
            openchildform(new Forms.Formproducts(),sender);
        }

        private void iconbtnorders_Click(object sender, EventArgs e)
        {
           // activeiconbutton(sender);
            openchildform(new Forms.Formorders(), sender);
        }

        private void iconbtncustomer_Click(object sender, EventArgs e)
        {
            //activeiconbutton(sender);
            openchildform(new Forms.Formcustomer(), sender);
        }

        private void iconbtnnotification_Click(object sender, EventArgs e)
        {
           // activeiconbutton(sender);
            openchildform(new Forms.Formnotification(), sender);
        }

        private void iconbtnsetting_Click(object sender, EventArgs e)
        {
           // activeiconbutton(sender);
            openchildform(new Forms.Formsetting(), sender);
        }
    }
}
