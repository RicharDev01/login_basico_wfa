using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasicoWFA
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
      this.BackColor = Color.FromArgb(40, 58, 72);
    }

    private void Login_Load(object sender, EventArgs e)
    {
      inPassword.PasswordChar = '*';
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      String username = inUsername.Text;
      String pass = inPassword.Text;

      if (username == "@Ricardo" && pass == "1234")
      {
        InicioApp app = new InicioApp();
        app.Show();
        //MessageBox.Show($"{username} te has logueado exitosamente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    }
  }
}
