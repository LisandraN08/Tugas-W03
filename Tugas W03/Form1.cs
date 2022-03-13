using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sistemKerja();
        }
        public void sistemKerja()
        {
            string coba1 = "";
            coba1 = txtBoxInput.Text;
            string[] teksAkhir = coba1.Split(':');
            if (coba1.Contains(':'))
            {
                teksAkhir[0] = teksAkhir[0].ToUpper();
                teksAkhir[1] = teksAkhir[1].ToUpper();
            }
            else
            {
                coba1 = coba1.ToUpper();
            }
            if (teksAkhir[0] == "ISI")
            {
                string text = "";
                text = txtBoxInput.Text;
                string[] textAkhir = text.Split(':');
                lblOutput.Text = textAkhir[1];
            }
            else if (coba1 == "SHOWN")
            {
                lblOutput.Show();
            }
            else if (coba1 == "HIDE")
            {
                lblOutput.Hide();
            }
            else if (teksAkhir[0] == "WARNA")
            {
                if (teksAkhir[1].Contains("DEFAULT"))
                {
                    lblOutput.ForeColor = Color.Black;
                }
                else if (teksAkhir[1].Contains("MERAH"))
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else if (teksAkhir[1].Contains("HIJAU"))
                {
                    lblOutput.ForeColor = Color.Green;
                }
                else if (teksAkhir[1].Contains("BIRU"))
                {
                    lblOutput.ForeColor = Color.Blue;
                }
            }
            else if (coba1 == "RESTART")
            {
                lblOutput.Text = "[EMPTY]";
                lblOutput.ForeColor = Color.Black;
                lblOutput.Font = new Font("Microsoft Sans Serif", 10.8F);
            }
            else if (coba1 == "BESARKAN")
            {
                lblOutput.Font = ChangeFontSize(lblOutput.Font, lblOutput.Font.Size+2);
            }
            else if (coba1 == "KECILKAN")
            {
                lblOutput.Font = ChangeFontSize(lblOutput.Font, lblOutput.Font.Size-2);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }
        static public Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }

    }
}
