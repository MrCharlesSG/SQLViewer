using SqlViewer.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); 
            HideError();
        }

        private void HideError() => lbError.Visible = false;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
			try
			{
				HideError();
				// exception driven, but ok
				RepositoryFactory.GetRepository().LogIn(tbServer.Text.Trim(), tbUsername.Text.Trim(), tbPassword.Text.Trim());
				new MainForm().Show(); //ShowDialog() to tightly coupled!!!
				//Dispose(); // we cannot dispose or close cause the child dies!
				Hide();
				// do not forget to catch Form_Closed of child to kill the application!
				// even if we close the form, Application is still running! do not do this!!!
				// we may need to rename the .exe file in bin directory to do this!!!
			}
			catch (Exception ex) // ex for debugging only!
			{
				lbError.Visible = true;
			}
		}
    }
}
