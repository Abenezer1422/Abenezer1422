using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class Form1 : Form
    {
        static int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();

            Point p = new Point(230 + i, 40 * i);
            tb.Location = p;

            this.Controls.Add(tb);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random=new Random();
            
            
            List<string> list = new List<string>();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    list.Add((c as TextBox).Text);
            }
            int index = random.Next(list.Count);
            label4.Text = list[index];

        }

        
    }
}
