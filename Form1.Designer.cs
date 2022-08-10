
namespace LoginBasicoWFA
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.imgLogo = new System.Windows.Forms.PictureBox();
      this.txtMensaje = new System.Windows.Forms.Label();
      this.inUsername = new System.Windows.Forms.TextBox();
      this.inPassword = new System.Windows.Forms.TextBox();
      this.txtUsuario = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // imgLogo
      // 
      this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
      this.imgLogo.Location = new System.Drawing.Point(132, 12);
      this.imgLogo.Name = "imgLogo";
      this.imgLogo.Size = new System.Drawing.Size(132, 128);
      this.imgLogo.TabIndex = 0;
      this.imgLogo.TabStop = false;
      // 
      // txtMensaje
      // 
      this.txtMensaje.AutoSize = true;
      this.txtMensaje.BackColor = System.Drawing.Color.Transparent;
      this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      this.txtMensaje.ForeColor = System.Drawing.Color.White;
      this.txtMensaje.Location = new System.Drawing.Point(91, 154);
      this.txtMensaje.Name = "txtMensaje";
      this.txtMensaje.Size = new System.Drawing.Size(217, 31);
      this.txtMensaje.TabIndex = 1;
      this.txtMensaje.Text = "Inicio de sesion";
      // 
      // inUsername
      // 
      this.inUsername.Location = new System.Drawing.Point(208, 220);
      this.inUsername.Name = "inUsername";
      this.inUsername.Size = new System.Drawing.Size(100, 20);
      this.inUsername.TabIndex = 2;
      // 
      // inPassword
      // 
      this.inPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(254)));
      this.inPassword.Location = new System.Drawing.Point(208, 265);
      this.inPassword.Name = "inPassword";
      this.inPassword.Size = new System.Drawing.Size(100, 19);
      this.inPassword.TabIndex = 3;
      // 
      // txtUsuario
      // 
      this.txtUsuario.AutoSize = true;
      this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      this.txtUsuario.ForeColor = System.Drawing.Color.White;
      this.txtUsuario.Location = new System.Drawing.Point(94, 225);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(57, 15);
      this.txtUsuario.TabIndex = 4;
      this.txtUsuario.Text = "Usuario";
      // 
      // txtPassword
      // 
      this.txtPassword.AutoSize = true;
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      this.txtPassword.ForeColor = System.Drawing.Color.White;
      this.txtPassword.Location = new System.Drawing.Point(94, 270);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(80, 15);
      this.txtPassword.TabIndex = 5;
      this.txtPassword.Text = "Contraseña";
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.White;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Location = new System.Drawing.Point(97, 330);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(211, 38);
      this.btnLogin.TabIndex = 6;
      this.btnLogin.Text = "Iniciar sesion";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(427, 409);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.inPassword);
      this.Controls.Add(this.inUsername);
      this.Controls.Add(this.txtMensaje);
      this.Controls.Add(this.imgLogo);
      this.Name = "Login";
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Login_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox imgLogo;
    private System.Windows.Forms.Label txtMensaje;
    private System.Windows.Forms.TextBox inUsername;
    private System.Windows.Forms.TextBox inPassword;
    private System.Windows.Forms.Label txtUsuario;
    private System.Windows.Forms.Label txtPassword;
    private System.Windows.Forms.Button btnLogin;
  }
}

