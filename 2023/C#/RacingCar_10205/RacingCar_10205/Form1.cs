using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar_10205
{
    public partial class Form1 : Form
    {
        int carSpeed = 0;
        Random rand = new Random();
        int x;
        int totalCoin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void MoveLine(int speed)
        {
            TopCheck(Cline3, speed);
            TopCheck(Cline2, speed);
            TopCheck(Cline1, speed);
        }

        void TopCheck(PictureBox pic, int speed)
        {
            if (pic.Top >= 500)
            {
                pic.Top = 0;
            }
            else
            {
                pic.Top += speed;
            }
        }


        private void timer_Tick(object sender, EventArgs e)     // Tick 이벤트가 발생할 때 실행될 메서드
        {
            MoveLine(carSpeed);
            EnemyCar(carSpeed);
            GameOver();
            Coins(carSpeed);
            CoinCollection();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  
        {
            if (e.KeyCode == Keys.Left)
            {
                if (MyCar.Left > 0)
                {
                    MyCar.Left -= 5;
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (MyCar.Left < 300)
                {
                    MyCar.Left += 5;
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 20)
                {
                    carSpeed++;
                }
            }

            else if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                {
                    carSpeed--;
                }
            }
        }

        void EnemyCar(int speed)
        {
            if (EnemyCar1.Top >= 500)
            {
                x = rand.Next(0, 200 - (EnemyCar2.Width));
                EnemyCar1.Location = new Point(x, 0);
            }

            else 
            {
                EnemyCar1.Top += speed;    
            }

            if (EnemyCar2.Top >= 500)
            {
                x = rand.Next(200, 400 - (EnemyCar2.Width));
                EnemyCar2.Location = new Point(x, 0);
            }

            else
            {
                EnemyCar2.Top += speed;
            }
           

        }

        void GameOver()
        {
            if (MyCar.Bounds.IntersectsWith(EnemyCar1.Bounds) || 
                MyCar.Bounds.IntersectsWith(EnemyCar2.Bounds))
            {
                ldl_GameOver.Visible = true;
                timer.Enabled = false;
            }

           
        }

        void Coins(int speed)
        {
            if (Coin1.Top >= 500)
            {
                x = rand.Next(0, 200 - (Coin1.Width));
                Coin1.Location = new Point(x, 0);
            }

            else
            {
                Coin1.Top += speed;
            }

            if (Coin2.Top >= 500)
            {
                x = rand.Next(130, 260 - (Coin2.Width));
                Coin2.Location = new Point(x, 0);
            }

            else
            {
                Coin2.Top += speed;
            }


            if (Coin3.Top >= 500)
            {
                x = rand.Next(130, 260 - (Coin3.Width));
                Coin3.Location = new Point(x, 0);
            }

            else
            {
                Coin3.Top += speed;
            }
        }

        void CoinCollection()
        {
            if (MyCar.Bounds.IntersectsWith(Coin1.Bounds))
            {
                totalCoin++;
                lbl_coin.Text = "Coins = " + totalCoin;

                x = rand.Next(0, 130 - (Coin1.Width));
                Coin1.Location = new Point(x, 0);
            }

            if (MyCar.Bounds.IntersectsWith(Coin2.Bounds))
            {
                totalCoin++;
                lbl_coin.Text = "Coins = " + totalCoin;

                x = rand.Next(0, 130 - (Coin2.Width));
                Coin2.Location = new Point(x, 0);
            }

            if (MyCar.Bounds.IntersectsWith(Coin3.Bounds))
            {
                totalCoin++;
                lbl_coin.Text = "Coins = " + totalCoin;

                x = rand.Next(0, 130 - (Coin3.Width));
                Coin3.Location = new Point(x, 0);
            }
        }

    }
}
