namespace Sua_Carteira {
  public partial class FormBase : Form {
    public FormBase() {
      InitializeComponent();
      Opacity = 0.0;
      ShowInTaskbar = false;
      FormBorderStyle = FormBorderStyle.None;
    }

    private void FormBase_Load(object sender, EventArgs e) {
      Size = new Size(0, 0);
      new FormLogin().Show();
    }

    protected override CreateParams CreateParams {
      get {
        CreateParams cp = base.CreateParams;
        cp.ExStyle |= 0x80;
        return cp;
      }
    }
  }
}
