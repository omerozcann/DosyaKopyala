using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Tüm dosya işlemleri için gerekli

namespace DosyaKopyala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            String[ ] dosyalar = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);
            progressBar1.Maximum = dosyalar.Length;

            //dosyaları kopyalıyoruz.
            for (int i = 0; i < dosyalar.Length; i++)
            {
                if (radioButton2.Checked)
                {
                    if (Path.GetExtension(dosyalar[i]) == ".jpg")
                    {
                        String dosyaadi = Path.GetFileName(dosyalar[i]);//dosyanın dizin hariç adını getir
                        File.Copy(dosyalar[i], textBox2.Text + "\\" + dosyaadi);//dosyayı hedef dizine kopyala
                    }
                }
                if (radioButton1.Checked)
                {
                    if (Path.GetExtension(dosyalar[i]) == ".exe")
                    {
                        String dosyaadi = Path.GetFileName(dosyalar[i]);//dosyanın dizin hariç adını getir
                        File.Copy(dosyalar[i], textBox2.Text + "\\" + dosyaadi);//dosyayı hedef dizine kopyala
                    }
                }
                if (radioButton3.Checked)
                {
                    if (Path.GetExtension(dosyalar[i]) == ".png")
                    {
                        String dosyaadi = Path.GetFileName(dosyalar[i]);//dosyanın dizin hariç adını getir
                        File.Copy(dosyalar[i], textBox2.Text + "\\" + dosyaadi);//dosyayı hedef dizine kopyala
                    }
                }
                if (radioButton4.Checked)
                {                 
                        String dosyaadi = Path.GetFileName(dosyalar[i]);//dosyanın dizin hariç adını getir
                        File.Copy(dosyalar[i], textBox2.Text + "\\" + dosyaadi);//dosyayı hedef dizine kopyala                   
                }
                if(checkBox1.Checked)//kaynak dosya silinsin seçeneği işaretli mi
                {
                    File.Delete(dosyalar[i]);//işaretliyse dosyayı sil
                }
                progressBar1.Value = i+1;//progressbar ın ilerlemesini sağla
            }
        }
    }
}
