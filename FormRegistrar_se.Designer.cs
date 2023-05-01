namespace Sua_Carteira {
  partial class FormRegistrar_se {
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
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnRegistrar = new System.Windows.Forms.Button();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.txtSenhaConfirmar = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(184, 195);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(205, 23);
      this.txtSenha.TabIndex = 10;
      this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
      this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(184, 177);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 9;
      this.label2.Text = "Senha";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(184, 135);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(205, 23);
      this.txtEmail.TabIndex = 8;
      this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
      this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(184, 117);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 15);
      this.label1.TabIndex = 7;
      this.label1.Text = "E-mail";
      // 
      // btnRegistrar
      // 
      this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegistrar.Location = new System.Drawing.Point(236, 297);
      this.btnRegistrar.Name = "btnRegistrar";
      this.btnRegistrar.Size = new System.Drawing.Size(95, 33);
      this.btnRegistrar.TabIndex = 6;
      this.btnRegistrar.Text = "Registrar-se";
      this.btnRegistrar.UseVisualStyleBackColor = true;
      this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(184, 78);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(205, 23);
      this.txtNome.TabIndex = 12;
      this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
      this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(184, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 15);
      this.label3.TabIndex = 11;
      this.label3.Text = "Nome";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // txtSenhaConfirmar
      // 
      this.txtSenhaConfirmar.Location = new System.Drawing.Point(184, 248);
      this.txtSenhaConfirmar.Name = "txtSenhaConfirmar";
      this.txtSenhaConfirmar.PasswordChar = '*';
      this.txtSenhaConfirmar.Size = new System.Drawing.Size(205, 23);
      this.txtSenhaConfirmar.TabIndex = 14;
      this.txtSenhaConfirmar.Leave += new System.EventHandler(this.txtSenhaConfirmar_Leave);
      this.txtSenhaConfirmar.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenhaConfirmar_Validating);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(184, 230);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 15);
      this.label4.TabIndex = 13;
      this.label4.Text = "Confirme a senha";
      // 
      // FormRegistrar_se
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(606, 388);
      this.Controls.Add(this.txtSenhaConfirmar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnRegistrar);
      this.MaximumSize = new System.Drawing.Size(622, 427);
      this.MinimumSize = new System.Drawing.Size(622, 427);
      this.Name = "FormRegistrar_se";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sua Carteira";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistrar_se_FormClosing);
      this.Load += new System.EventHandler(this.FormRegistrar_se_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox txtSenha;
    private Label label2;
    private TextBox txtEmail;
    private Label label1;
    private Button btnRegistrar;
    private TextBox txtNome;
    private Label label3;
    private ErrorProvider errorProvider1;
    private TextBox txtSenhaConfirmar;
    private Label label4;
  }
}