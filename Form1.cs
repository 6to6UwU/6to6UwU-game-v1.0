using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeButtonVisibility(false);
        }
        private void changeButtonVisibility(bool visible)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.Substring(0, 6) == "button")
                {
                    button.Visible = visible;
                }
            }
        }
        static int stage = 1;
        private void test_button_Click(object sender, EventArgs e)
        {
            switch(stage)
                {
                case 1:
                test_button.Location =new Point (569, 635);
                test_button.Text = "no just joke man don't click me";
                break;

                case 2:
                test_button.Location = new Point(863, 875);
                test_button.Text = "are you stupid? I say don't click";
                break;

                case 3:
                test_button.Location = new Point(1234, 215);
                test_button.Text = "ONE MORE TRY AND YOU GONNA PAY FOR THIS!!!";
                break;

                case 4:
                test_button.Location = new Point(305, 415);
                test_button.Text = "oke click me again and i gonna troll you!";
                break;

                case 5:
                test_button.Location = new Point(569, 635);
                test_button.Text = "mhm you click me. Try again.";
                break;
                
                case 6:
                test_button.Location = new Point(797, 346);
                test_button.Text = "click me!";
                changeButtonVisibility(true);
                button1.Focus();
                break; 
     
                case 7:
                test_button.Text = "NOOO THIS IS NOT POSSIBLE!!! HOW YOU FIND ME?";
                changeButtonVisibility(false);
                break;

                case 8:
                test_button.Text = "ok you can find me but for now!";
                break;
                }
            stage++;
        }      
    }
}
