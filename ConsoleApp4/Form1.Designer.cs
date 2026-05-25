namespace UrunGosterApp
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox listBoxUrunler;

        private void InitializeComponent()
        {
            this.btnGoster = new System.Windows.Forms.Button();
            this.listBoxUrunler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.btnGoster.Location = new System.Drawing.Point(30, 30);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(150, 30);
            this.btnGoster.Text = "Urunleri Goster";
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);

            this.listBoxUrunler.FormattingEnabled = true;
            this.listBoxUrunler.ItemHeight = 15;
            this.listBoxUrunler.Location = new System.Drawing.Point(30, 80);
            this.listBoxUrunler.Name = "listBoxUrunler";
            this.listBoxUrunler.Size = new System.Drawing.Size(300, 150);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.listBoxUrunler);
            this.Name = "Form1";
            this.Text = "Urun Listesi";
            this.ResumeLayout(false);
        }
    }
}
