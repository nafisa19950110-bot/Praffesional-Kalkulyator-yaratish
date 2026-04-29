using System;
using System.Windows.Forms;

namespace Kalkulyator_yaratish
{
    public partial class Form1 : Form
    {
        double birinchiSon = 0;
        string amal = "";
        bool yangiSon = true;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Raqamlar uchun (0-9 tugmalariga bog'lang)
        private void Raqam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (yangiSon)
            {
                textBox1.Text = btn.Text;
                yangiSon = false;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        // 2. Arifmetik amallar (+, -, *, /)
        private void Amal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            birinchiSon = double.Parse(textBox1.Text);
            amal = btn.Text;
            yangiSon = true;
        }

        // 3. Tenglik tugmasi (=) - MANA SHU SIZDA YO'Q EDI
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double ikkinchiSon = double.Parse(textBox1.Text);
            double natija = 0;

            if (amal == "+") natija = birinchiSon + ikkinchiSon;
            else if (amal == "-") natija = birinchiSon - ikkinchiSon;
            else if (amal == "x" || amal == "*") natija = birinchiSon * ikkinchiSon;
            else if (amal == "/")
            {
                if (ikkinchiSon != 0) natija = birinchiSon / ikkinchiSon;
                else MessageBox.Show("Nolga bo'lish mumkin emas!");
            }

            textBox1.Text = natija.ToString();
            yangiSon = true;
        }

        // 4. Kvadrat ildiz (√)
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double son = double.Parse(textBox1.Text);
            if (son >= 0)
            {
                textBox1.Text = Math.Sqrt(son).ToString();
                yangiSon = true;
            }
            else
            {
                MessageBox.Show("Manfiy sondan ildiz chiqarib bo'lmaydi!");
            }
        }

        // 5. Foiz (%)
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            double ikkinchiSon = double.Parse(textBox1.Text);
            double natija = (birinchiSon * ikkinchiSon) / 100;
            textBox1.Text = natija.ToString();
            yangiSon = true;
        }

        // 6. Tozalash (C)
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            birinchiSon = 0;
            amal = "";
            yangiSon = true;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            // Ekranda turgan sonni o'qiymiz
            double son = double.Parse(textBox1.Text);

            // Sonni kvadratga oshiramiz (son * son)
            double natija = Math.Pow(son, 2);

            // Natijani ekranga chiqaramiz
            textBox1.Text = natija.ToString();

            // Keyingi son yozilganda ekran tozalanishi uchun
            yangiSon = true;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double son = double.Parse(textBox1.Text);
            if (son >= 0)
            {
                textBox1.Text = Math.Sqrt(son).ToString();
                yangiSon = true;
            }
            else
            {
                MessageBox.Show("Manfiy sondan ildiz chiqarib bo'lmaydi!");
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double son = double.Parse(textBox1.Text);
            double natija = son / 100;
            textBox1.Text = natija.ToString();
            yangiSon = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double son = double.Parse(textBox1.Text);
            son = son * -1;
            textBox1.Text = son.ToString();
        }
    }
}