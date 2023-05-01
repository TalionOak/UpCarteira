namespace Sua_Carteira {
  partial class FormLogin {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.btnEntrar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnRegistrar = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnEntrar
      // 
      this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEntrar.Location = new System.Drawing.Point(243, 221);
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.Size = new System.Drawing.Size(93, 31);
      this.btnEntrar.TabIndex = 2;
      this.btnEntrar.Text = "Entrar";
      this.btnEntrar.UseVisualStyleBackColor = true;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(191, 101);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "E-mail";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(191, 119);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(205, 23);
      this.txtEmail.TabIndex = 0;
      this.txtEmail.Text = "admin@admin.com";
      this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
      this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(191, 179);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(205, 23);
      this.txtSenha.TabIndex = 1;
      this.txtSenha.Text = "admin";
      this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
      this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(191, 161);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Senha";
      // 
      // btnRegistrar
      // 
      this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegistrar.Location = new System.Drawing.Point(243, 268);
      this.btnRegistrar.Name = "btnRegistrar";
      this.btnRegistrar.Size = new System.Drawing.Size(93, 31);
      this.btnRegistrar.TabIndex = 3;
      this.btnRegistrar.Text = "Registrar-se";
      this.btnRegistrar.UseVisualStyleBackColor = true;
      this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(606, 388);
      this.Controls.Add(this.btnRegistrar);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnEntrar);
      this.MaximumSize = new System.Drawing.Size(622, 427);
      this.MinimumSize = new System.Drawing.Size(622, 427);
      this.Name = "FormLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sua Carteira";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
      this.Load += new System.EventHandler(this.FormLogin_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnEntrar;
    private Label label1;
    private TextBox txtEmail;
    private TextBox txtSenha;
    private Label label2;
    private Button btnRegistrar;
    private ErrorProvider errorProvider1;
  }
}