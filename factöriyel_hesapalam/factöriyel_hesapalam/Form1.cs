using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factöriyel_hesapalam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("*************fibonaci Sayilari****************");
                int sayi1 = 1;
                int sayi2 = 1;
                int sayi3 = 0;
                listBox1.Items.Add(sayi1);
                listBox1.Items.Add(sayi2);
                for (int i = 0; i <= sayi; i++)
                {
                    sayi3 = sayi1 + sayi2;
                    sayi1 = sayi2;
                    sayi2 = sayi3;

                    listBox1.Items.Add(sayi3);
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("*************Faktöriyel Hesaplama****************");
                int fibonacci = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    fibonacci = fibonacci * i;
                }
                listBox1.Items.Add("sayi=" + fibonacci + " " + "!");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("*************Kareler toplami****************");
                int kareler_toplami = 0;
                for (int j = 1; j <= sayi; j++)
                {
                    kareler_toplami += j * j;
                }
                listBox1.Items.Add("karelerin toplami=" + kareler_toplami);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add("*************chart sayilar****************");
                while (sayi > 1)
                {

                    listBox1.Items.Add("sayi:" + " " + sayi);
                    if (sayi % 2 == 0)
                    {
                        sayi = sayi / 2;

                    }
                    else if (sayi % 2 == 1)
                    {
                        sayi = sayi * 3 + 1;
                    }
                    else if (sayi == 1)
                    {
                        break;
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                listBox1.Items.Add("*************sayilarin toplami****************");
                int toplam =0;
                for(int i=0;i<=sayi;i++)
                {
                    toplam += i;
                }
                listBox1.Items.Add("sayilarin toplami=" + toplam);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            comboBox1.Text = "";
        }
    }
}
