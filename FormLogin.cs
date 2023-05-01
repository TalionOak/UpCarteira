using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sua_Carteira {
  public partial class FormLogin : Form {

    public FormLogin() {
      InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e) {
      new FormRegistrar_se(this).Show();
      this.Hide();
    }

    private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
      Application.Exit();
    }

    private void FormLogin_Load(object sender, EventArgs e) {

    }
  }
}