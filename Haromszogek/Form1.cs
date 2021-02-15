using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hibaLb.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string sor;
                int sorSzam = 1;
                while ((sor = streamReader.ReadLine()) != null)
                {
                    try
                    {
                        haromszogek.Items.Add(new DHaromszog(sor, sorSzam));
                    }
                    catch (Exception exept)
                    {
                        hibaLb.Text += sorSzam + ".sor: " + exept.Message + "\n";
                    }
                    sorSzam++;
                }
                streamReader.Close();
            }
        }

        private void haromszogek_SelectedIndexChanged(object sender, EventArgs e)
        {
            DHaromszog h = haromszogek.SelectedItem as DHaromszog;
            if (h == null)
            {
                return;
            }
            label1.Text = h.Kerulet.ToString();
            label2.Text = h.Terulet.ToString();
        }
    }
}
