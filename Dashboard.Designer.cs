
namespace login
{
    partial class Dashboard
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Usermenu = new FontAwesome.Sharp.IconMenuItem();
            this.Mainteinermenu = new FontAwesome.Sharp.IconMenuItem();
            this.salesmenu = new FontAwesome.Sharp.IconMenuItem();
            this.Shoppingmenu = new FontAwesome.Sharp.IconMenuItem();
            this.Customermenu = new FontAwesome.Sharp.IconMenuItem();
            this.suppliersmenu = new FontAwesome.Sharp.IconMenuItem();
            this.Graphicmenu = new FontAwesome.Sharp.IconMenuItem();
            this.menuinfo = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.menutitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usermenu,
            this.Mainteinermenu,
            this.salesmenu,
            this.Shoppingmenu,
            this.Customermenu,
            this.suppliersmenu,
            this.Graphicmenu,
            this.menuinfo});
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menu.Size = new System.Drawing.Size(863, 77);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // Usermenu
            // 
            this.Usermenu.AutoSize = false;
            this.Usermenu.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.Usermenu.IconColor = System.Drawing.Color.Black;
            this.Usermenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usermenu.IconSize = 50;
            this.Usermenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usermenu.Name = "Usermenu";
            this.Usermenu.Size = new System.Drawing.Size(80, 69);
            this.Usermenu.Text = "Usuario";
            this.Usermenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Mainteinermenu
            // 
            this.Mainteinermenu.AutoSize = false;
            this.Mainteinermenu.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.Mainteinermenu.IconColor = System.Drawing.Color.Black;
            this.Mainteinermenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mainteinermenu.IconSize = 50;
            this.Mainteinermenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Mainteinermenu.Name = "Mainteinermenu";
            this.Mainteinermenu.Size = new System.Drawing.Size(80, 69);
            this.Mainteinermenu.Text = "Mantenedor";
            this.Mainteinermenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // salesmenu
            // 
            this.salesmenu.AutoSize = false;
            this.salesmenu.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.salesmenu.IconColor = System.Drawing.Color.Black;
            this.salesmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesmenu.IconSize = 50;
            this.salesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salesmenu.Name = "salesmenu";
            this.salesmenu.Size = new System.Drawing.Size(80, 69);
            this.salesmenu.Text = "Ventas";
            this.salesmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Shoppingmenu
            // 
            this.Shoppingmenu.AutoSize = false;
            this.Shoppingmenu.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.Shoppingmenu.IconColor = System.Drawing.Color.Black;
            this.Shoppingmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Shoppingmenu.IconSize = 50;
            this.Shoppingmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Shoppingmenu.Name = "Shoppingmenu";
            this.Shoppingmenu.Size = new System.Drawing.Size(80, 69);
            this.Shoppingmenu.Text = "Compras";
            this.Shoppingmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Customermenu
            // 
            this.Customermenu.AutoSize = false;
            this.Customermenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Customermenu.IconColor = System.Drawing.Color.Black;
            this.Customermenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customermenu.IconSize = 50;
            this.Customermenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Customermenu.Name = "Customermenu";
            this.Customermenu.Size = new System.Drawing.Size(80, 69);
            this.Customermenu.Text = "Clientes";
            this.Customermenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // suppliersmenu
            // 
            this.suppliersmenu.AutoSize = false;
            this.suppliersmenu.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.suppliersmenu.IconColor = System.Drawing.Color.Black;
            this.suppliersmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suppliersmenu.IconSize = 50;
            this.suppliersmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suppliersmenu.Name = "suppliersmenu";
            this.suppliersmenu.Size = new System.Drawing.Size(80, 69);
            this.suppliersmenu.Text = "Proveedores";
            this.suppliersmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Graphicmenu
            // 
            this.Graphicmenu.AutoSize = false;
            this.Graphicmenu.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.Graphicmenu.IconColor = System.Drawing.Color.Black;
            this.Graphicmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Graphicmenu.IconSize = 50;
            this.Graphicmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Graphicmenu.Name = "Graphicmenu";
            this.Graphicmenu.Size = new System.Drawing.Size(80, 69);
            this.Graphicmenu.Text = "Grafico";
            this.Graphicmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuinfo
            // 
            this.menuinfo.AutoSize = false;
            this.menuinfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuinfo.IconColor = System.Drawing.Color.Black;
            this.menuinfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinfo.IconSize = 50;
            this.menuinfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinfo.Name = "menuinfo";
            this.menuinfo.Size = new System.Drawing.Size(80, 69);
            this.menuinfo.Text = "Acerca de";
            this.menuinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.menutitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(863, 62);
            this.menutitulo.TabIndex = 2;
            this.menutitulo.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 54);
            this.toolStripMenuItem1.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menutitulo.ResumeLayout(false);
            this.menutitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem Mainteinermenu;
        private FontAwesome.Sharp.IconMenuItem salesmenu;
        private FontAwesome.Sharp.IconMenuItem Shoppingmenu;
        private FontAwesome.Sharp.IconMenuItem Customermenu;
        private FontAwesome.Sharp.IconMenuItem suppliersmenu;
        private FontAwesome.Sharp.IconMenuItem Graphicmenu;
        private FontAwesome.Sharp.IconMenuItem menuinfo;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem Usermenu;
    }
}