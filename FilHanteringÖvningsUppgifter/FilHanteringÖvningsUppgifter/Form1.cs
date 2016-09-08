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

namespace FilHanteringÖvningsUppgifter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            using (StreamWriter file =
            new StreamWriter(@"C:\Users\Mattias\Desktop\WriteText.txt", true))
            {
                file.WriteLine(textBox1.Text);
            }

            //File.WriteAllText(@"C:\Users\Mattias\Desktop\WriteText.txt", textBox1.Text);        
        }

        public void LoadFromDataBase()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Mattias\Desktop\WriteText.txt"))
            {
                textBox2.Text = sr.ReadToEnd();              
            }

            //textBox2.Text = File.ReadAllText(@"C:\Users\Mattias\Desktop\WriteText.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFromDataBase();
        }
    }
}
