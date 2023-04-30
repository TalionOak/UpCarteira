using Sua_Carteira.Classes;

namespace Sua_Carteira {
  public partial class FormMainMenu : Form {

    private Button currentButton;
    private Random random;
    private int tempIndex;

    public FormMainMenu() {
      InitializeComponent();
      random = new Random();
    }

    private Color SelectThemeColor() {
      int index = random.Next(ThemeColor.ColorList.Count);
      while(tempIndex == index) {
       index =  random.Next(ThemeColor.ColorList.Count);
      }
      tempIndex = index;
      string color = ThemeColor.ColorList[index];
      return ColorTranslator.FromHtml(color);
    }

    private void ActivateButton(object btnSender) {
      if(btnSender != null) {
        if(currentButton != (Button) btnSender) {
          DisableButton();
          Color color = SelectThemeColor();
          currentButton = (Button) btnSender;
          currentButton.BackColor = color;
          currentButton.ForeColor = Color.Black;
          currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
      }
    }

    private void DisableButton() {
      foreach(Control previousBtn in panelLeft.Controls) {
        if(previousBtn.GetType() == typeof(Button)) {
          previousBtn.BackColor = Color.FromArgb(54, 194, 255);
          previousBtn.ForeColor = Color.Black;
          previousBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
      }
    }

    private void btnDispesas_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnContas_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnGraficos_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnCategorias_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnPagamentosRegulares_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnLembrete_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnMoedas_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void btnConfiguracoes_Click(object sender, EventArgs e) {
      ActivateButton(sender);
    }

    private void FormMainMenu_Load(object sender, EventArgs e) {
      ActivateButton(sender);
    }
  }
}