namespace Sua_Carteira.Forms {
  partial class FormContas {
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
      this.btnNovaConta = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnNovaConta
      // 
      this.btnNovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNovaConta.Location = new System.Drawing.Point(341, 409);
      this.btnNovaConta.Name = "btnNovaConta";
      this.btnNovaConta.Size = new System.Drawing.Size(118, 29);
      this.btnNovaConta.TabIndex = 0;
      this.btnNovaConta.Text = "Nova conta";
      this.btnNovaConta.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Location = new System.Drawing.Point(12, 92);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(776, 311);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(800, 44);
      this.label1.TabIndex = 2;
      this.label1.Text = "Total:\r\nR$ 100,\r\n";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 44);
      this.panel2.TabIndex = 2;
      // 
      // FormContas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnNovaConta);
      this.Name = "FormContas";
      this.Text = "CONTAS";
      this.Load += new System.EventHandler(this.FormContas_Load);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Button btnNovaConta;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
  }
}