using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "aba aea aca aza axa";
           
            Regex regex = new Regex("a[bex]a");
            // добавляем результаты в коллекцию
            MatchCollection matches = regex.Matches(str);
            
            if (matches.Count > 0)
            {
                // заполняем листбокс результатами
                for (int i = 0; i < matches.Count; i++)
                {
                    listBox1.Items.Add(matches[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
        
            Regex regex = new Regex("a[a-f][j-z]a");
            // добавляем результаты в коллекцию
            MatchCollection matches = regex.Matches(str);
          
            if (matches.Count > 0)
            {
                // заполняем листбокс результатами
                for (int i = 0; i < matches.Count; i++)
                {
                    listBox2.Items.Add(matches[i]);
                }
            }
        }
    }
}
