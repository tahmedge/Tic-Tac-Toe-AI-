using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int track = 0;
        int type = 1;
        int[] ar = new int[10];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++) ar[i] = 0;
            Random R = new Random();
            type = R.Next(1, 3);
           // type = x;
            if(type==2)
            {
                track++;
                int x = R.Next(1, 10);
                if (ar[x] == 0)
                {
                    //f = 1;
                    ar[x] = 2;
                    if (x == 1)
                    {
                        button1.Enabled = false;
                        button1.Text = "0";
                    }
               else    if (x == 2)
                    {
                        button2.Enabled = false;
                        button2.Text = "0";
                    }
              else      if (x == 3)
                    {
                        button3.Enabled = false;
                        button3.Text = "0";
                    }
               else     if (x == 4)
                    {
                        button4.Enabled = false;
                        button4.Text = "0";
                    }
               else     if (x == 5)
                    {
                        button5.Enabled = false;
                        button5.Text = "0";
                    }
               else     if (x == 6)
                    {
                        button6.Enabled = false;
                        button6.Text = "0";
                    }
               else     if (x == 7)
                    {
                        button7.Enabled = false;
                        button7.Text = "0";
                    }
               else     if (x == 8)
                    {
                        button8.Enabled = false;
                        button8.Text = "0";
                    }
               else     if (x == 9)
                    {
                        button9.Enabled = false;
                        button9.Text = "0";
                    }
                }
            }
           
        }
        public int auto()
        {

            if (ar[1] == ar[2] && ar[2]!=0&&ar[3]==0)
            {
                ar[3] = 2;
                button3.Text = "0";
                button3.Enabled = false;
            }
            else if (ar[2] == ar[3] && ar[3] !=0 && ar[1] == 0)
            {
                ar[1] = 2;
                button1.Enabled = false;
                button1.Text = "0";
            }
            else if (ar[1] == ar[3] && ar[3] !=0 && ar[2] == 0)
            {
                ar[2] = 2;
                button2.Enabled = false;
                button2.Text = "0";
            }


            else if (ar[7] == ar[8] && ar[8] !=0&&ar[9]==0)
            {
                ar[9] = 2;
                button9.Enabled = false;
                button9.Text = "0";
            }
            else if (ar[7] == ar[9] && ar[9] !=0 && ar[8] == 0)
            {
                ar[8] = 2;
                button8.Enabled = false;
                button8.Text = "0";
            }
            else if (ar[8] == ar[9] && ar[9] !=0 && ar[7] == 0)
            {
                ar[7] = 2;
                button7.Enabled = false;
                button7.Text = "0";
            }


            else if (ar[4] == ar[5] && ar[5] !=0 && ar[6] == 0)
            {
                ar[6] = 2;
                button6.Enabled = false;
                button6.Text = "0";
            }
            else if (ar[4] == ar[6] && ar[6] !=0 && ar[5] == 0)
            {
                ar[5] = 2;
                button5.Enabled = false;
                button5.Text = "0";
            }
            else if (ar[5] == ar[6] && ar[5]!=0 && ar[4] == 0)
            {
                ar[4] = 2;
                button4.Enabled = false;
                button4.Text = "0";
            }


            else if (ar[1] == ar[4] && ar[4]!=0 && ar[7] == 0)
            {
                ar[7] = 2;
                button7.Enabled = false;
                button7.Text = "0";
            }
            else if (ar[1] == ar[7] && ar[1]!=0 && ar[4] == 0)
            {
                ar[4] = 2;
                button4.Enabled = false;
                button4.Text = "0";
            }
            else if (ar[4] == ar[7] && ar[4] !=0 && ar[1] == 0)
            {
                ar[1] = 2;
                button1.Enabled = false;
                button1.Text = "0";
            }


            else if (ar[2] == ar[5] && ar[2] !=0 && ar[8] == 0)
            {
                ar[8] = 2;
                button8.Enabled = false;
                button8.Text = "0";
            }
            else if (ar[2] == ar[8] && ar[2] !=0&& ar[5] == 0)
            {
                ar[5] = 2;
                button5.Enabled = false;
                button5.Text = "0";
            }
            else if (ar[5] == ar[8] && ar[8] !=0 && ar[2] == 0)
            {
                ar[2] = 2;
                button2.Enabled = false;
                button2.Text = "0";
            }



            else if (ar[3] == ar[6] && ar[6] !=0 && ar[9] == 0)
            {
                ar[9] = 2;
                button9.Enabled = false;
                button9.Text = "0";
            }
            else if (ar[3] == ar[9] && ar[3] !=0 && ar[6] == 0)
            {
                ar[6] = 2;
                button6.Enabled = false;
                button6.Text = "0";
            }
            else if (ar[6] == ar[9] && ar[6] !=0 && ar[3] == 0)
            {
                ar[3] = 2;
                button3.Enabled = false;
                button3.Text = "0";
            }



            else if (ar[1] == ar[5] && ar[1] !=0 && ar[9] == 0)
            {
                ar[9] = 2;
                button9.Enabled = false;
                button9.Text = "0";
            }
            else if (ar[1] == ar[9] && ar[1]!=0 && ar[5] == 0)
            {
                ar[5] = 2;
                button5.Enabled = false;
                button5.Text = "0";
            }
            else if (ar[5] == ar[9] && ar[5] !=0 && ar[1] == 0)
            {
                ar[1] = 2;
                button1.Enabled = false;
                button1.Text = "0";
            }


            else if (ar[3] == ar[5] && ar[5] !=0 && ar[7] == 0)
            {
                ar[7] = 2;
                button7.Enabled = false;
                button7.Text = "0";
            }
            else if (ar[3] == ar[7] && ar[3] !=0 && ar[5] == 0)
            {
                ar[5] = 2;
                button5.Enabled = false;
                button5.Text = "0";
            }
            else if (ar[5] == ar[7] && ar[5] !=0 && ar[3] == 0)
            {
                ar[3] = 2;
                button3.Enabled = false;
                button3.Text = "0";
            }

            else
            {
                int f = 0;
                if (track>=9) f = 1;
                while (f == 0)
                {
                    Random R = new Random();
                    int x = R.Next(1, 10);
                    if(ar[x]==0)
                    {
                        f = 1;
                        ar[x] = 2;
                        if(x==1)
                        {
                            button1.Enabled = false;
                            button1.Text = "0";
                        }
                        if (x == 2)
                        {
                            button2.Enabled = false;
                            button2.Text = "0";
                        }
                        if (x == 3)
                        {
                            button3.Enabled = false;
                            button3.Text = "0";
                        }
                        if (x == 4)
                        {
                            button4.Enabled = false;
                            button4.Text = "0";
                        }
                        if (x == 5)
                        {
                            button5.Enabled = false;
                            button5.Text = "0";
                        }
                        if (x == 6)
                        {
                            button6.Enabled = false;
                            button6.Text = "0";
                        }
                        if (x == 7)
                        {
                            button7.Enabled = false;
                            button7.Text = "0";
                        }
                        if (x == 8)
                        {
                            button8.Enabled = false;
                            button8.Text = "0";
                        }
                        if (x == 9)
                        {
                            button9.Enabled = false;
                            button9.Text = "0";
                        }
                    }
                }
            }
            return 0;
        }
        public int reset()
        {
            track = 0;
            for (int i = 0; i < 10; i++) ar[i] = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            Random R = new Random();
            type = R.Next(1, 3);
            // type = x;
            if (type == 2)
            {
                track++;
                int x = R.Next(1, 10);
                if (ar[x] == 0)
                {
                    //f = 1;
                    ar[x] = 2;
                    if (x == 1)
                    {
                        button1.Enabled = false;
                        button1.Text = "0";
                    }
                else    if (x == 2)
                    {
                        button2.Enabled = false;
                        button2.Text = "0";
                    }
               else     if (x == 3)
                    {
                        button3.Enabled = false;
                        button3.Text = "0";
                    }
                else    if (x == 4)
                    {
                        button4.Enabled = false;
                        button4.Text = "0";
                    }
               else     if (x == 5)
                    {
                        button5.Enabled = false;
                        button5.Text = "0";
                    }
               else     if (x == 6)
                    {
                        button6.Enabled = false;
                        button6.Text = "0";
                    }
               else     if (x == 7)
                    {
                        button7.Enabled = false;
                        button7.Text = "0";
                    }
               else     if (x == 8)
                    {
                        button8.Enabled = false;
                        button8.Text = "0";
                    }
               else     if (x == 9)
                    {
                        button9.Enabled = false;
                        button9.Text = "0";
                    }
                }
            }
                return 0;            
        }
        public int check()
        {

            if(ar[1]==ar[2]&&ar[2]==ar[3])
            {
                if (ar[1] == 1 || ar[1] == 2)
                {
                    MessageBox.Show("Player " + ar[1].ToString() + " wins");
                    reset();
                    return 3;
                }
                return 1;
            }

          else  if (ar[1] == ar[4] && ar[4] == ar[7])
            {
                if (ar[1] == 1 || ar[1] == 2)
                {
                    MessageBox.Show("Player " + ar[1].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

         else   if (ar[1] == ar[5] && ar[5] == ar[9])
            {
                if (ar[1] == 1 || ar[1] == 2)
                {
                    MessageBox.Show("Player " + ar[1].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

         else   if (ar[2] == ar[5] && ar[5] == ar[8])
            {
                if (ar[2] == 1 || ar[2] == 2)
                {
                    MessageBox.Show("Player " + ar[2].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

          else  if (ar[3] == ar[5] && ar[5] == ar[7])
            {
                if (ar[3] == 1 || ar[3] == 2)
                {
                    MessageBox.Show("Player " + ar[3].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

        else    if (ar[3] == ar[6] && ar[6] == ar[9])
            {
                if (ar[3] == 1 || ar[3] == 2)
                {
                    MessageBox.Show("Player " + ar[3].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

       else     if (ar[4] == ar[5] && ar[5] == ar[6])
            {
                if (ar[4] == 1 || ar[4] == 2)
                {
                    MessageBox.Show("Player " + ar[4].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }

            else   if (ar[7] == ar[8] && ar[8] == ar[9])
            {
                if (ar[7] == 1 || ar[7] == 2)
                {
                    MessageBox.Show("Player " + ar[7].ToString() + " wins");
                    reset();
                    return 3;
                }
                    return 1;
            }
            else if(track>=9)
            {
                MessageBox.Show("It's a draw");
                reset();
                return 2;
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            track++;
            button1.Enabled = false;
            ar[1] = 1;
            button1.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            track++;
            button2.Enabled = false;
            ar[2] = 1;
            button2.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            track++;
            button3.Enabled = false;
            ar[3] = 1;
            button3.Text = "X";
            int v = check();
            if (v != 3&&v!=2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            track++;
            button4.Enabled = false;
            ar[4] = 1;
            button4.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            track++;
            button5.Enabled = false;
            ar[5] = 1;
            button5.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            track++;
            button6.Enabled = false;
            ar[6] = 1;
            button6.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            track++;
            button7.Enabled = false;
            ar[7] = 1;
            button7.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            track++;
            button8.Enabled = false;
            ar[8] = 1;
            button8.Text = "X";
            int v = check();
            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            track++;
            button9.Enabled = false;
            ar[9] = 1;
            button9.Text = "X";
            int v = check();

            if (v != 3 && v != 2)
            {
                // track++;
                auto();
                track++;
                check();
            }
        }
    }
}
 