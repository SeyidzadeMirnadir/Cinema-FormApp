using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string[] Arr = { "H", "G", "F", "D", "C", "B", "A", "K" };
        List<string> Mylist = new List<string>();
        public void Form1_Load(object sender, EventArgs e)
        {
            int top = 50;
            for (int j = 0; j < 8; j++)
            {
                
                int left = 100; 
                var counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    Button bt = new Button();
                    counter += bt.Width;
                    bt.Text =Arr[j]+(i+1);
                    bt.Name = Arr[j];
                    this.Controls.Add(bt);
                    bt.Left = left;
                    bt.Click += Myclick;
                    left += 80;
                    bt.Top = top;
                }
                top += 30;
            }
        }
        void Myclick(object B, EventArgs E )
        {
            Button bt = B as Button;
            bt.Enabled = false;
            Mylist.Add(bt.Text);
        }
        public void SaveList()
        {
            
            foreach (var item in Mylist)
            {
                textBox1.Text += item+" ";
                
            }
            Mylist.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveList();
        }
    }
}
