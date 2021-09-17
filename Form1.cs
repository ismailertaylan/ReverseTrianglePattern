using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TersDuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string eklenecek = "";
            int i = first.Length - 1;
            int j = 0, adim = 0;
            while (i > 0)
            {
                eklenecek += first[i];
                i--;
            }

            eklenecek += first;
            listBox1.Items.Add(eklenecek);
            adim++;
            while (first.Length > 0)
            {
                first = first.Substring(1, first.Length - 1);
                eklenecek = "";
                int dongu = adim;
                while (dongu > 0)
                {
                    eklenecek += "  ";
                    dongu--;
                }
                i = first.Length - 1;
                j = 0;
                while (i > 0)
                {
                    eklenecek += first[i];
                    i--;
                }
                eklenecek += first;
                if(eklenecek!="")
                listBox1.Items.Add(eklenecek);
                adim++;
            }
        }

    }
}
