using Sua_Carteira.Dados;
using System.Text;
using System.Text.RegularExpressions;

namespace Sua_Carteira {
  public partial class FormLogin : Form {

    private Banco banco;
    private string senha;
    private string email;
    private bool fecharApp = true;

    public FormLogin() {
      InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e) {
      new FormRegistrar_se(this).Show();
      this.Hide();
    }

    private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
      if (fecharApp) {
        Application.Exit();
      }
    }

    private void FormLogin_Load(object sender, EventArgs e) {
      banco = new Banco();
    }

    private string EncriptarSenha(string senha) {
      byte[] data = Encoding.ASCII.GetBytes(senha);
      data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
      string hash = Encoding.ASCII.GetString(data);
      return hash;
    }

    private void btnEntrar_Click(object sender, EventArgs e) {
      email = txtEmail.Text;
      senha = txtSenha.Text;

      if (ValidateChildren(ValidationConstraints.Enabled)) {
        var encontrou = banco.Usuarios.Where(x => x.Email == email && x.Senha == EncriptarSenha(senha)).FirstOrDefault();
        if (encontrou != null) {
          new FormMainMenu().Show();
          fecharApp = false;
          this.Close();
          return;
        } else {
          MessageBox.Show("E-mail ou senha não encontrado! Você está realmente cadastrado?");
        }
      };
    }

    #region Validação
    private bool IsEmail(string email) {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }

    private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(email)) {
        e.Cancel = true;
        errorProvider1.SetError(txtEmail, "Por favor, insira um e-mail!");
      } else if (!IsEmail(email)) {
        e.Cancel = true;
        errorProvider1.SetError(txtEmail, "E-mail informado não é valido!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtEmail, null);
      }
    }

    private void txtSenha_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (string.IsNullOrEmpty(senha)) {
        e.Cancel = true;
        errorProvider1.SetError(txtSenha, "Por favor, insira uma senha!");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txtSenha, null);
      }
    }
    #endregion

    #region Setando valores
    private void txtEmail_Leave(object sender, EventArgs e) {
      email = txtEmail.Text;
    }

    private void txtSenha_Leave(object sender, EventArgs e) {
      senha = txtSenha.Text;
    }
    #endregion
  }
}