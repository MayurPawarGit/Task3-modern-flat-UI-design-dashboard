using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Task3_modern_flat_UI_design_dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
                int nLeftRect,
                int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));
            panelnav.Height = iconbtndashboard.Height;
            panelnav.Top = iconbtndashboard.Top;
            panelnav.Left = iconbtndashboard.Left;
            iconbtndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

       
            

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void iconbtndashboard_Click(object sender, EventArgs e)
        {
            panelnav.Height = iconbtndashboard.Height;
            panelnav.Top = iconbtndashboard.Top;
            panelnav.Left = iconbtndashboard.Left;
            iconbtndashboard.BackColor=Color.FromArgb(46,51,73);
        }

        private void iconbtnanalytics_Click(object sender, EventArgs e)
        {
            panelnav.Height = iconbtnanalytics.Height;
            panelnav.Top =iconbtnanalytics.Top;
            iconbtnanalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void iconbtncalender_Click(object sender, EventArgs e)
        {
            panelnav.Height = iconbtncalender.Height;
            panelnav.Top = iconbtncalender.Top;
            iconbtncalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void iconbtncontact_Click(object sender, EventArgs e)
        {
            panelnav.Height = iconbtncontact.Height;
            panelnav.Top = iconbtncontact.Top;
            iconbtncontact.BackColor = Color.FromArgb(46, 51, 73); 
        }

        private void iconbtnsetting_Click(object sender, EventArgs e)
        {
            panelnav.Height = iconbtnsetting.Height;
            panelnav.Top = iconbtnsetting.Top;
            iconbtnsetting.BackColor = Color.FromArgb(46, 51, 73); 
        }

        private void iconbtndashboard_Leave(object sender, EventArgs e)
        {
            iconbtndashboard.BackColor = Color.DarkSlateGray;
        }

        private void iconbtnanalytics_Leave(object sender, EventArgs e)
        {
            iconbtnanalytics.BackColor = Color.DarkSlateGray;
        }

        private void iconbtncalender_Leave(object sender, EventArgs e)
        {
            iconbtncalender.BackColor = Color.DarkSlateGray;
        }

        private void iconbtncontact_Leave(object sender, EventArgs e)
        {
            iconbtncontact.BackColor = Color.DarkSlateGray;
        }

        private void iconbtnsetting_Leave(object sender, EventArgs e)
        {
            iconbtnsetting.BackColor = Color.DarkSlateGray;
        }
    }
}
