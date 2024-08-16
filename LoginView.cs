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
            try
            {
                string email = TextBoxLoginEmail.Text;
                string password = TextBoxLoginPassword.Text;
                BaseController controller = new LoginController(email, password);
                controller.Handle();

                // TODO: Create a UI helper to handle the switching between screens
                new Dashboard().Show();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void CloseButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
