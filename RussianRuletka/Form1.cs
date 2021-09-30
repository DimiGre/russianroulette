using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RussianRuletka
{
    public partial class Form1 : Form
    {
        List<bullet> bullets = new List<bullet>(6);

        class bullet
        {
            public Boolean pt = true;
        }
        Boolean hp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string abc = " ";
          
            
                bullets.Clear();
               
                
                    bullets.Add(new bullet() { pt = true });
                    for (int i = 1; i < 6; i++)
                    {
                        bullets.Add(new bullet() { pt = false });
                    }
                }

                void button5_Click(object sender, EventArgs e)
                {
                    Random rand = new Random();
                    int t = rand.Next(bullets.Count);
                    if (bullets[t].pt == true)
                    {
                        bullets[t].pt = false;
                        hp = true;
                    }
                }

                void button6_Click(object sender, EventArgs e)
                {
                    if (hp == true)
                    {
                        hp = false;
                        MessageBox.Show("Лол, ну ты эт самое, помер, гыгыгыгы");
                    }
                }

            

        }
    }
