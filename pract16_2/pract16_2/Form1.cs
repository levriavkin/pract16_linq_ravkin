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

namespace pract16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            string[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int digitCount = array.SelectMany(s => s).Count(char.IsDigit);
            richTextBox2.AppendText($"Количество цифр в массиве: {digitCount}\n\n");

            richTextBox2.AppendText("Элементы массива до символа \"/\":\n");
            foreach (string s in array.TakeWhile(s => s != "/"))
            {
                richTextBox2.AppendText(s + "\n");
            }
            richTextBox2.AppendText("\n");

            richTextBox2.AppendText("Элементы массива после символа \"/\", в верхнем и нижнем регистре:\n");
            string[] newArray = array.SkipWhile(s => s != "/").Skip(1).Select(s => s.ToUpper() == s ? s.ToLower() : s.ToUpper()).ToArray();
            foreach (string s in newArray)
            {
                richTextBox2.AppendText(s + "\n");
            }

            File.WriteAllLines("output.txt", newArray);
        }

    }
}

