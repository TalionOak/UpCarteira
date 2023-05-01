using Sua_Carteira.Dados;
using Sua_Carteira.Dados.Entidades;
using System.Text.RegularExpressions;

namespace Sua_Carteira {
  public partial class FormRegistrar_se : Form {

    private Form formLogin;
    private Banco ctx;
    private Usuarios usuario;
    private string senhaConfirmar;

    public FormRegistrar_se(Form formLogin) {
      InitializeComponent();
      this.formLogin = formLogin;
    }

    private void btnRegistrar_Click(object sender, EventArgs e) {
      if (ValidateChildren(ValidationConstraints.Enabled)) {
        this.Close();
      };
    }

    private void FormRegistrar_se_FormClosing(object sender, FormClosingEventArgs e) {
      formLogin.Show();
    }

    private void FormRegistrar_se_Load(object sender, EventArgs e) {
      ctx = new Banco();
      usuario = new Usuarios();
    }

    private void txtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(txtNome.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txtNome, "Por favor, insira um nome!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtNome, null);
      }
    }

    private bool IsEmail(string email) {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }

    private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(txtEmail.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txtEmail, "Por favor, insira um e-mail!");
      } else if (!IsEmail(usuario.Email)){
        e.Cancel = true;
        errorProvider1.SetError(txtEmail, "E-mail informado não é valido!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtEmail, null);
      }
    }

    private void txtSenha_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(txtSenha.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txtSenha, "Por favor, insira uma senha!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtSenha, null);
      }
    }

    private void txtSenha_Leave(object sender, EventArgs e) {
      usuario.Senha = txtSenha.Text;
    }

    private void txtSenhaConfirmar_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(txtSenhaConfirmar.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txtSenhaConfirmar, "Por favor, confirme a senha!");
      } else if (usuario.Senha != senhaConfirmar) {
        e.Cancel = true;
        errorProvider1.SetError(txtSenhaConfirmar, "As senhas não são iguais!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtSenhaConfirmar, null);
      }
    }

    private void txtSenhaConfirmar_Leave(object sender, EventArgs e) {
      senhaConfirmar = txtSenhaConfirmar.Text;
    }

    private void txtEmail_Leave(object sender, EventArgs e) {
      usuario.Email = txtEmail.Text;
    }

    private void txtNome_Leave(object sender, EventArgs e) {
      usuario.Nome = txtNome.Text;
    }
  }
}
