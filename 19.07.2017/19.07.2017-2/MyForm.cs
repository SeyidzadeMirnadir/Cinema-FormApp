using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._07._2017_2
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        public void form_load(object mySender, EventArgs myEvent)
        {

           
            var counterHeight = 0;
            for (int i = 0; i < 5; i++)
            {
                
                var counterWidth = 0;
             
                for (int j = 0; j < 9; j++)
                {
                    
                    Button btn = new Button();
                    btn.Top = i * btn.Height;
                    counterWidth += btn.Width;
                    btn.Text = "Button" + (i*10+j+1);
                    this.Controls.Add(btn);
                    btn.Left = counterWidth;
                    btn.Click += btn_click;
                }



            }





        }
        void btn_click(object myButton, EventArgs newEvent)
        {
            Button  btn= myButton as Button;
            btn.Enabled = false;
            btn.BackColor = Color.Aqua;
            

        }

        
    }
}
