using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace UrunGosterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonPath = "Urunler.json";

                if (!File.Exists(jsonPath))
                {
                    MessageBox.Show("JSON dosyasi bulunamadi!");
                    return;
                }

                string jsonString = File.ReadAllText(jsonPath);
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonString);

                listBoxUrunler.Items.Clear();

                if (urunler != null)
                {
                    foreach (Urun urun in urunler)
                    {
                        listBoxUrunler.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                    }
                }
                else
                {
                    MessageBox.Show("JSON dosyasi bos veya hatali formatta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu:\n" + ex.Message);
            }
        }
    }
}
