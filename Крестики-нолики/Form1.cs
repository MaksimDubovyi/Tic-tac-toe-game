namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        int []ar = new int []{1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool i,pc;
        int x=2;
        public Form1()
        {
            InitializeComponent();

        }
        bool examination(int []ar)
        {
            if (ar[0] == 10 && ar[3] == 10 && ar[6] == 10)
            {
                return true;
            }
            else if (ar[1] == 10 && ar[4] == 10 && ar[7] == 10)
            {
                return true;
            }
            else if (ar[1] == 10 && ar[4] == 10 && ar[7] == 10)
            {
                return true;
            }
            else if (ar[2] == 10 && ar[5] == 10 && ar[8] == 10)
            {
                return true;
            }
            else if (ar[0] == 10 && ar[1] == 10 && ar[2] == 10)
            {
                return true;
            }
            else if (ar[3] == 10 && ar[4] == 10 && ar[5] == 10)
            {
                return true;
            }
            else if (ar[6] == 10 && ar[7] == 10 && ar[8] == 10)
            {
                return true;
            }
            else if (ar[2] == 10 && ar[4] == 10 && ar[6] == 10)
            {
                return true;
            }
            else if (ar[0] == 10 && ar[4] == 10 && ar[8] == 10)
            {
                return true;
            }
            else
                return false;
        }
        bool PC_Examination(int[] ar)
        {
            if (ar[0] == 0 && ar[3] == 0 && ar[6] ==0)
            {
                return true;
            }
            else if (ar[1] == 0 && ar[4] == 0 && ar[7] == 0)
            {
                return true;
            }
            else if (ar[1] == 0 && ar[4] == 0 && ar[7] == 0)
            {
                return true;
            }
            else if (ar[2] == 0 && ar[5] == 0 && ar[8] == 0)
            {
                return true;
            }
            else if (ar[0] == 0 && ar[1] == 0 && ar[2] == 0)
            {
                return true;
            }
            else if (ar[3] == 0 && ar[4] == 0 && ar[5] == 0)
            {
                return true;
            }
            else if (ar[6] == 0 && ar[7] == 0 && ar[8] == 0)
            {
                return true;
            }
            else if (ar[2] == 0 && ar[4] == 0 && ar[6] == 0)
            {
                return true;
            }
            else if (ar[0] == 0 && ar[4] == 0 && ar[8] == 0)
            {
                return true;
            }
            else
                return false;
        }

        void Examin01()
        {
            int one = 0;
            for (int i = 0; i < 9; i++)
            {
                if (ar[i] != 0 && ar[i] != 10)
                {

                    one = i;
                    break;
                }

            }
            switch (one)
            {
                case 0:
                    ar[0] = 0;
                    button1.Image = Image.FromFile("0.bmp");
                    break;
                case 1:
                    ar[1] = 0;
                    button2.Image = Image.FromFile("0.bmp");
                    break;
                case 2:
                    ar[2] = 0;
                    button3.Image = Image.FromFile("0.bmp");
                    break;
                case 3:
                    ar[3] = 0;
                    button4.Image = Image.FromFile("0.bmp");
                    break;
                case 4:
                    ar[4] = 0;
                    button5.Image = Image.FromFile("0.bmp");
                    break;
                case 5:
                    ar[5] = 0;
                    button6.Image = Image.FromFile("0.bmp");
                    break;
                case 6:
                    ar[6] = 0;
                    button7.Image = Image.FromFile("0.bmp");
                    break;
                case 7:
                    ar[7] = 0;
                    button8.Image = Image.FromFile("0.bmp");
                    break;
                case 8:
                    ar[8] = 0;
                    button9.Image = Image.FromFile("0.bmp");
                    break;
            }
            }
        bool Examin1()
        {
            if(ar[0] == 0 && ar[1] == 0&& ar[2]!=0&& ar[2]!=10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 0 && ar[2] == 0&&ar[1] != 0 && ar[1] != 10)
            {
                ar[1] = 0;
                button2.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if(ar[1] == 0 && ar[2] == 0 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin2()
        {
            if (ar[3] == 0 && ar[4] == 0 && ar[5] != 0 && ar[5] != 10)
            {
                ar[5] = 0;
                button6.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[3] == 0 && ar[5] == 0 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[4] == 0 && ar[5] == 0 && ar[3] != 0 && ar[3] != 10)
            {
                ar[3] = 0;
                button4.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin3()
        {
            if (ar[6] == 0 && ar[7] == 0 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 0 && ar[8] == 0 && ar[7] != 0 && ar[7] != 10)
            {
                ar[7] = 0;
                button8.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[7] == 0 && ar[8] == 0 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin4()
        {
            if (ar[0] == 0 && ar[3] == 0 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 0 && ar[3] == 0 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 0 && ar[6] == 0 && ar[3] != 0 && ar[3] != 10)
            {
                ar[3] = 0;
                button4.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin5()
        {
            if (ar[1] == 0 && ar[4] == 0 && ar[7] != 0 && ar[7] != 10)
            {
                ar[7] = 0;
                button8.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[7] == 0 && ar[4] == 0 && ar[1] != 0 && ar[1] != 10)
            {
                ar[1] = 0;
                button2.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[1] == 0 && ar[7] == 0 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin6()
        {
            if (ar[2] == 0 && ar[5] == 0 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[8] == 0 && ar[5] == 0 && ar[2] != 0 && ar[2] != 10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[2] == 0 && ar[8] == 0 && ar[5] != 0 && ar[5] != 10)
            {
                ar[5] = 0;
                button6.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin7()
        {
            if (ar[0] == 0 && ar[4] == 0 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[8] == 0 && ar[4] == 0 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 0 && ar[8] == 0 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Examin8()
        {
            if (ar[2] == 0 && ar[4] == 0 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 0 && ar[4] == 0 && ar[2] != 0 && ar[2] != 10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[2] == 0 && ar[6] == 0 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }



        bool Block1()
        {
            if (ar[0] == 10 && ar[1] == 10 && ar[2] != 0 && ar[2] != 10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 10 && ar[2] == 10 && ar[1] != 0 && ar[1] != 10)
            {
                ar[1] = 0;
                button2.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[1] == 10 && ar[2] == 10 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block2()
        {
            if (ar[3] == 10 && ar[4] == 10 && ar[5] != 0 && ar[5] != 10)
            {
                ar[5] = 0;
                button6.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[3] == 10 && ar[5] == 10 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[4] == 10 && ar[5] == 10 && ar[3] != 0 && ar[3] != 10)
            {
                ar[3] = 0;
                button4.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block3()
        {
            if (ar[6] == 10 && ar[7] == 10 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 10 && ar[8] == 10 && ar[7] != 0 && ar[7] != 10)
            {
                ar[7] = 0;
                button8.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[7] == 10 && ar[8] == 10 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block4()
        {
            if (ar[0] == 10 && ar[3] == 10 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 10 && ar[3] == 10 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 10 && ar[6] == 10 && ar[3] != 0 && ar[3] != 10)
            {
                ar[3] = 0;
                button4.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block5()
        {
            if (ar[1] == 10 && ar[4] == 10 && ar[7] != 0 && ar[7] != 10)
            {
                ar[7] = 0;
                button8.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[7] == 10 && ar[4] == 10 && ar[1] != 0 && ar[1] != 10)
            {
                ar[1] = 0;
                button2.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[1] == 10 && ar[7] == 10 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block6()
        {
            if (ar[2] == 10 && ar[5] == 10 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[8] == 10 && ar[5] == 10 && ar[2] != 0 && ar[2] != 10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[2] == 10 && ar[8] == 10 && ar[5] != 0 && ar[5] != 10)
            {
                ar[5] = 0;
                button6.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block7()
        {
            if (ar[0] == 10 && ar[4] == 10 && ar[8] != 0 && ar[8] != 10)
            {
                ar[8] = 0;
                button9.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[8] ==10 && ar[4] == 10 && ar[0] != 0 && ar[0] != 10)
            {
                ar[0] = 0;
                button1.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[0] == 10 && ar[8] == 10 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Block8()
        {
            if (ar[2] == 10 && ar[4] == 10 && ar[6] != 0 && ar[6] != 10)
            {
                ar[6] = 0;
                button7.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[6] == 10 && ar[4] == 10 && ar[2] != 0 && ar[2] != 10)
            {
                ar[2] = 0;
                button3.Image = Image.FromFile("0.bmp");
                return true;
            }
            else if (ar[2] == 10 && ar[6] == 10 && ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                return true;
            }
            else
            {
                return false;
            }
        }
        bool RadioButton3Block()
        {
            bool x=false;
            if (x != true)
                x = Block1();
            if (x != true)
                x = Block2();
            if (x != true)
                x = Block3();
            if (x != true)
                x = Block4();
            if (x != true)
                x = Block5();
            if (x != true)
                x = Block6();
            if (x != true)
                x = Block7();
            if (x != true)
                x = Block8();

            return x;

        }
        void RadioButton2Examination()
        {
            bool x = false;
            if (ar[4] != 0 && ar[4] != 10)
            {
                ar[4] = 0;
                button5.Image = Image.FromFile("0.bmp");
                x = true;
            }
            else
            {
                if (x != true)
                    x = Examin1();
                if (x != true)
                    x = Examin2();
                if (x != true)
                    x = Examin3();
                if (x != true)
                    x = Examin4();
                if (x != true)
                    x = Examin5();
                if (x != true)
                    x = Examin6();
                if (x != true)
                    x = Examin7();
                if (x != true)
                    x = Examin8();
            }
            if (x == false)
            {
                Examin01();
            }
        }

        void RadioButton3Examination()
        {
            bool y = false;
           y= RadioButton3Block();
            if(y != true)
            RadioButton2Examination();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Examin01();

            }
            else if (radioButton2.Checked)
            {
                RadioButton2Examination();
            }
            else if (radioButton3.Checked)
            {
                RadioButton3Examination();
            }

            pc =PC_Examination(ar);
            if (pc == true)
            {
                Win.Text = "Вы проиграли!";
                timer1.Stop();
                x = 2;
            }
            else if (pc == false)
            {
                timer1.Stop();
                x = 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ar[0] != 0 && ar[0] != 10 && x == 1)
            {
                ar[0] = 10;
                button1.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ar[1] != 0 && ar[1] != 10&&x==1)
            {
                ar[1] = 10;
                button2.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ar[2] != 0 && ar[2] != 10 && x == 1)
            {
                ar[2] = 10;
                button3.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ar[3] != 0 && ar[3] != 10 && x == 1)
            {
                ar[3] = 10;
                button4.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ar[4] != 0 && ar[4] != 10 && x == 1)
            {
                ar[4] = 10;
                button5.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ar[5] != 0 && ar[5] != 10 && x == 1)
            {
                ar[5] = 10;
                button6.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ar[6] != 0 && ar[6] != 10 && x == 1)
            {
                ar[6] = 10;
                button7.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ar[7] != 0 && ar[7] != 10 && x == 1)
            {
                ar[7] = 10;
                button8.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ar[8] != 0 && ar[8] != 10 && x == 1)
            {
                ar[8] = 10;
                button9.Image = Image.FromFile("x.bmp");
                i = examination(ar);
                if (i == true)
                {
                    Win.Text = "Вы победили";
                    timer1.Stop();
                    x = 2;
                }
                else if (i == false)
                {
                    timer1.Start();
                    x = 0;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                x = 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                ar[i] = i + 1;
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            Win.Text = " ";
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                x = 1;
            }
        }
    }
}