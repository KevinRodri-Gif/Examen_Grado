using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DegreeExamen.App.Controllers;
using DegreeExamen.App.Controllers.Auth;

namespace DegreeExamen
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = TextBoxLoginEmail.Text;
            string password = TextBoxLoginPassword.Text;
            BaseController controller = new LoginController(email, password);
            controller.Handle();
        }

        private void CloseButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
