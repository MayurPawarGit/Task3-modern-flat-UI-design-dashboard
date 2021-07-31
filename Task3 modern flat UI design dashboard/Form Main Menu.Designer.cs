namespace Task3_modern_flat_UI_design_dashboard
{
    partial class Form_Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.labelhome = new System.Windows.Forms.Label();
            this.labelcomname = new System.Windows.Forms.Label();
            this.paneldesktoppanel = new System.Windows.Forms.Panel();
            this.iconbtnsetting = new FontAwesome.Sharp.IconButton();
            this.iconbtnnotification = new FontAwesome.Sharp.IconButton();
            this.iconbtncustomer = new FontAwesome.Sharp.IconButton();
            this.iconbtnorders = new FontAwesome.Sharp.IconButton();
            this.iconbtnproducts = new FontAwesome.Sharp.IconButton();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Teal;
            this.panelmenu.Controls.Add(this.iconbtnsetting);
            this.panelmenu.Controls.Add(this.iconbtnnotification);
            this.panelmenu.Controls.Add(this.iconbtncustomer);
            this.panelmenu.Controls.Add(this.iconbtnorders);
            this.panelmenu.Controls.Add(this.iconbtnproducts);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 542);
            this.panelmenu.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panellogo.Controls.Add(this.labelcomname);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 80);
            this.panellogo.TabIndex = 0;
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.paneltitlebar.Controls.Add(this.labelhome);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(220, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(721, 80);
            this.paneltitlebar.TabIndex = 1;
            // 
            // labelhome
            // 
            this.labelhome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelhome.AutoSize = true;
            this.labelhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhome.Location = new System.Drawing.Point(335, 30);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(49, 16);
            this.labelhome.TabIndex = 0;
            this.labelhome.Text = "Home";
            // 
            // labelcomname
            // 
            this.labelcomname.AutoSize = true;
            this.labelcomname.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcomname.ForeColor = System.Drawing.Color.Honeydew;
            this.labelcomname.Location = new System.Drawing.Point(27, 28);
            this.labelcomname.Name = "labelcomname";
            this.labelcomname.Size = new System.Drawing.Size(163, 24);
            this.labelcomname.TabIndex = 0;
            this.labelcomname.Text = "Royal Accenture";
            // 
            // paneldesktoppanel
            // 
            this.paneldesktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktoppanel.Location = new System.Drawing.Point(220, 80);
            this.paneldesktoppanel.Name = "paneldesktoppanel";
            this.paneldesktoppanel.Size = new System.Drawing.Size(721, 462);
            this.paneldesktoppanel.TabIndex = 2;
            // 
            // iconbtnsetting
            // 
            this.iconbtnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnsetting.FlatAppearance.BorderSize = 0;
            this.iconbtnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnsetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconbtnsetting.IconColor = System.Drawing.Color.Black;
            this.iconbtnsetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnsetting.Location = new System.Drawing.Point(0, 320);
            this.iconbtnsetting.Name = "iconbtnsetting";
            this.iconbtnsetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconbtnsetting.Size = new System.Drawing.Size(220, 60);
            this.iconbtnsetting.TabIndex = 5;
            this.iconbtnsetting.Text = "Settings";
            this.iconbtnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnsetting.UseVisualStyleBackColor = true;
            this.iconbtnsetting.Click += new System.EventHandler(this.iconbtnsetting_Click);
            // 
            // iconbtnnotification
            // 
            this.iconbtnnotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnnotification.FlatAppearance.BorderSize = 0;
            this.iconbtnnotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnnotification.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconbtnnotification.IconColor = System.Drawing.Color.Black;
            this.iconbtnnotification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnnotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnnotification.Location = new System.Drawing.Point(0, 260);
            this.iconbtnnotification.Name = "iconbtnnotification";
            this.iconbtnnotification.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconbtnnotification.Size = new System.Drawing.Size(220, 60);
            this.iconbtnnotification.TabIndex = 4;
            this.iconbtnnotification.Text = "Notification";
            this.iconbtnnotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnnotification.UseVisualStyleBackColor = true;
            this.iconbtnnotification.Click += new System.EventHandler(this.iconbtnnotification_Click);
            // 
            // iconbtncustomer
            // 
            this.iconbtncustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtncustomer.FlatAppearance.BorderSize = 0;
            this.iconbtncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtncustomer.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconbtncustomer.IconColor = System.Drawing.Color.Black;
            this.iconbtncustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtncustomer.Location = new System.Drawing.Point(0, 200);
            this.iconbtncustomer.Name = "iconbtncustomer";
            this.iconbtncustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconbtncustomer.Size = new System.Drawing.Size(220, 60);
            this.iconbtncustomer.TabIndex = 3;
            this.iconbtncustomer.Text = "Customer";
            this.iconbtncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtncustomer.UseVisualStyleBackColor = true;
            this.iconbtncustomer.Click += new System.EventHandler(this.iconbtncustomer_Click);
            // 
            // iconbtnorders
            // 
            this.iconbtnorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnorders.FlatAppearance.BorderSize = 0;
            this.iconbtnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnorders.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconbtnorders.IconColor = System.Drawing.Color.Black;
            this.iconbtnorders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnorders.Location = new System.Drawing.Point(0, 140);
            this.iconbtnorders.Name = "iconbtnorders";
            this.iconbtnorders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconbtnorders.Size = new System.Drawing.Size(220, 60);
            this.iconbtnorders.TabIndex = 2;
            this.iconbtnorders.Text = "Orders";
            this.iconbtnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnorders.UseVisualStyleBackColor = true;
            this.iconbtnorders.Click += new System.EventHandler(this.iconbtnorders_Click);
            // 
            // iconbtnproducts
            // 
            this.iconbtnproducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnproducts.FlatAppearance.BorderSize = 0;
            this.iconbtnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnproducts.ForeColor = System.Drawing.Color.Black;
            this.iconbtnproducts.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconbtnproducts.IconColor = System.Drawing.Color.Black;
            this.iconbtnproducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnproducts.Location = new System.Drawing.Point(0, 80);
            this.iconbtnproducts.Name = "iconbtnproducts";
            this.iconbtnproducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.iconbtnproducts.Size = new System.Drawing.Size(220, 60);
            this.iconbtnproducts.TabIndex = 1;
            this.iconbtnproducts.Text = "Products";
            this.iconbtnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnproducts.UseVisualStyleBackColor = true;
            this.iconbtnproducts.Click += new System.EventHandler(this.iconbtnproducts_Click);
            // 
            // Form_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 542);
            this.Controls.Add(this.paneldesktoppanel);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenu);
            this.Name = "Form_Main_Menu";
            this.Text = "Form_Main_Menu";
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton iconbtnsetting;
        private FontAwesome.Sharp.IconButton iconbtnnotification;
        private FontAwesome.Sharp.IconButton iconbtncustomer;
        private FontAwesome.Sharp.IconButton iconbtnorders;
        private FontAwesome.Sharp.IconButton iconbtnproducts;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labelcomname;
        private System.Windows.Forms.Panel paneldesktoppanel;
    }
}