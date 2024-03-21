using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonByeBye
{
    public partial class Form1 : Form
    {

        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TROLL_Click(object sender, EventArgs e)
        {
            label1.Text = "Edi wow";
        }
        private void TROLL_MouseMove(object sender, MouseEventArgs e)
        {
            if (counter < 100)
            {
                Random r = new Random();
                int x = r.Next(12, 400);
                int y = r.Next(212, 500);
                TROLL.Location = new Point(x, y);

                if (counter >= 99)
                {
                    
                    taunt.Text = "FINE YOU CAN CLICK IT!";
                }

                else if(counter > 75)
                {
                    taunt.Text = "I SAID STOP";
                    
                }

                else if (counter > 40)
                {
                    taunt.Text = "STOP";
                    
                }

                else if (counter > 10)
                {
                    taunt.Text = "You're gonna have to try harder than that";
                    
                }

                

                counter++;
            }

        }

        private void no_Click(object sender, EventArgs e)
        {
            label1.Text = "Tama yan :)";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(keyData))
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }
    }
}
