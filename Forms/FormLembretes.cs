using Sua_Carteira.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sua_Carteira.Forms {
  public partial class FormLembretes : Form {
    public FormLembretes() {
      InitializeComponent();
    }

    private void FormLembretes_Load(object sender, EventArgs e) {
      LoadTheme();
    }

    private void LoadTheme() {
      foreach (Control btns in this.Controls) {
        if (btns.GetType() == typeof(Button)) {
          Button btn = (Button) btns;
          btn.BackColor = ThemeColor.PrimaryColor;
          btns.ForeColor = Color.Black;
          btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
      }
    }
  }
}
