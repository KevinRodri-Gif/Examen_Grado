using System;
using System.Windows.Forms;
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
 
        }


        private void CloseButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
