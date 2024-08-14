
namespace DegreeExamen
{
    partial class LoginView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.ErrorProvidertxtpassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvidertxtEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButtonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidertxtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidertxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorProvidertxtpassword
            // 
            this.ErrorProvidertxtpassword.ContainerControl = this;
            // 
            // ErrorProvidertxtEmail
            // 
            this.ErrorProvidertxtEmail.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 296);
            this.label5.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.LawnGreen;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Location = new System.Drawing.Point(50, 251);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(92, 23);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Iniciar Sesión";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButtonClose
            // 
            this.CloseButtonClose.BackColor = System.Drawing.Color.Red;
            this.CloseButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtonClose.Location = new System.Drawing.Point(177, 251);
            this.CloseButtonClose.Name = "CloseButtonClose";
            this.CloseButtonClose.Size = new System.Drawing.Size(92, 23);
            this.CloseButtonClose.TabIndex = 5;
            this.CloseButtonClose.Text = "Cerrar";
            this.CloseButtonClose.UseVisualStyleBackColor = false;
            this.CloseButtonClose.Click += new System.EventHandler(this.CloseButtonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // TextBoxLoginEmail
            // 
            this.TextBoxLoginEmail.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLoginEmail.Location = new System.Drawing.Point(51, 165);
            this.TextBoxLoginEmail.Name = "TextBoxLoginEmail";
            this.TextBoxLoginEmail.Size = new System.Drawing.Size(234, 20);
            this.TextBoxLoginEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña";
            // 
            // TextBoxLoginPassword
            // 
            this.TextBoxLoginPassword.Location = new System.Drawing.Point(51, 213);
            this.TextBoxLoginPassword.Name = "TextBoxLoginPassword";
            this.TextBoxLoginPassword.Size = new System.Drawing.Size(234, 20);
            this.TextBoxLoginPassword.TabIndex = 1;
            this.TextBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bienvenido";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sistema de Control ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxLoginPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TextBoxLoginEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CloseButtonClose);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ButtonLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 296);
            this.panel2.TabIndex = 9;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidertxtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidertxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvidertxtpassword;
        private System.Windows.Forms.ErrorProvider ErrorProvidertxtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLoginEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonLogin;
    }


    
}

