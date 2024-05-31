using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class Squash : Form
    {
        Graphics GDI;

        List<Ball> BallList;

        List<Brick> bricks;

        Rocket Rock;

        //Brick bricks;

        int speed;
        bool ArrowLeftHold, ArrowRightHold;

        Brush  EraseBrush, RocketBrush;

        private void Squash_MouseDown(object sender, MouseEventArgs e)
        {

        }

      

        private void Squash_Paint(object sender, PaintEventArgs e)
        {
            Rock.Show(true);
            foreach(var brick in bricks)
            {
                brick.Show(true);
            }
            
        }

        public Squash()
        {
            InitializeComponent();
            BallList = new List<Ball>();
            bricks = new List<Brick>();
        }

        private void Squash_Load(object sender, EventArgs e)
        {
            ArrowLeftHold = false;
            ArrowRightHold = false;
            GDI = this.CreateGraphics();
            speed = 3;
           
            EraseBrush = new SolidBrush(this.BackColor);
            RocketBrush = new SolidBrush(Color.Green);


            BallList.Add(
                new Ball
                {
                    x = (this.ClientSize.Width - 20) / 2,
                    y = (this.ClientSize.Height - 20) / 2,
                    D = 20,
                    Vx = speed,
                    Vy = -speed,
                    GDI = GDI,
                    BallBrush = new SolidBrush(Color.Blue),
                    EraseBrush = EraseBrush
                });
            BallList.Add(
                new Ball
                {
                    x = (this.ClientSize.Width - 20) / 2,
                    y = (this.ClientSize.Height - 20) / 2,
                    D = 20,
                    Vx = -speed,
                    Vy = -speed,
                    GDI = GDI,
                    BallBrush = new SolidBrush(Color.Red),
                    EraseBrush = EraseBrush
                });

            #region PlusTwo
            //BallList.Add(
            //  new Ball
            //  {
            //      x = (this.ClientSize.Width - 20) / 2,
            //      y = (this.ClientSize.Height - 20) / 2,
            //      D = 20,
            //      Vx = 2,
            //      Vy = 2,
            //      GDI = GDI,
            //      BallBrush = new SolidBrush(Color.Yellow),
            //      EraseBrush = EraseBrush
            //  });
            //BallList.Add(
            //  new Ball
            //  {
            //      x = (this.ClientSize.Width - 20) / 2,
            //      y = (this.ClientSize.Height - 20) / 2,
            //      D = 20,
            //      Vx = -2,
            //      Vy = 2,
            //      GDI = GDI,
            //      BallBrush = new SolidBrush(Color.DarkBlue),
            //      EraseBrush = EraseBrush
            //  });
            #endregion

            #region Magneta
            //   BallList.Add(
            //   new Ball
            //    {
            //        x = (this.ClientSize.Width - 20) / 2,
            //        y = (this.ClientSize.Height - 20) / 2,
            //        D = 20,
            //        Vx = -4,
            //        Vy = 4,
            //        GDI = GDI,
            //        BallBrush = new SolidBrush(Color.Magenta),
            //        EraseBrush = EraseBrush
            //    });
            //   BallList.Add(
            //   new Ball
            //    {
            //        x = (this.ClientSize.Width - 20) / 2,
            //        y = (this.ClientSize.Height - 20) / 2,
            //        D = 20,
            //        Vx = 4,
            //        Vy = -4,
            //        GDI = GDI,
            //        BallBrush = new SolidBrush(Color.Magenta),
            //        EraseBrush = EraseBrush
            //    });
            //    BallList.Add(
            //new Ball
            //{
            //    x = (this.ClientSize.Width - 20) / 2,
            //    y = (this.ClientSize.Height - 20) / 2,
            //    D = 20,
            //    Vx = 4,
            //    Vy = 4,
            //    GDI = GDI,
            //    BallBrush = new SolidBrush(Color.Magenta),
            //    EraseBrush = EraseBrush
            //});
            //    BallList.Add(
            //new Ball
            //{
            //    x = (this.ClientSize.Width - 20) / 2,
            //    y = (this.ClientSize.Height - 20) / 2,
            //    D = 20,
            //    Vx = -4,
            //    Vy = -4,
            //    GDI = GDI,
            //    BallBrush = new SolidBrush(Color.Magenta),
            //    EraseBrush = EraseBrush
            //});
            #endregion

            Rock = new Rocket
            {
                Rx = (this.ClientSize.Width - 100) / 2,
            Ry = this.ClientSize.Height - 12 - 2,
            Vr = 15,
            Rw = 50,
            Rh = 12,
            GDI = GDI,
            EraseBrush = EraseBrush,
            RocketBrush = RocketBrush
            };

            bricks.Add(
                new Brick
            {
                Power = 3,
                x = 500,
                y = 10,
                w = 100,
                h = 70,
                PaintBrush = new SolidBrush(Color.Black),
                EraseBrush = EraseBrush,
                GDI = GDI
            });

            bricks.Add(
                new Brick
                {
                    Power = 3,
                    x = 200,
                    y = 10,
                    w = 100,
                    h = 70,
                    PaintBrush = new SolidBrush(Color.Black),
                    EraseBrush = EraseBrush,
                    GDI = GDI
                });

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Brick BrokenBrick = null;
            Ball MissedBall = null; // Ссылка на удаляемый шарик
            foreach (var ball in BallList)
            {
                ball.Show(true);
                foreach (var brick in bricks)
                {

                    ball.x += ball.Vx;
                    ball.y += ball.Vy;

                    #region Check of the board
                    if (ball.x <= 0)
                    {
                        ball.Vx = -ball.Vx;
                        ball.x = 0;
                    }
                    if (ball.y <= 0)
                    {
                        ball.Vy = -ball.Vy;
                        ball.y = 0;
                    }

                    if (ball.x >= this.ClientSize.Width - ball.D)
                    {
                        ball.Vx = -ball.Vx;
                        ball.x = this.ClientSize.Width - ball.D;
                    }
                    /*
                    if (ball.y >= this.ClientSize.Height)
                    {
                        ball.Vy = -ball.Vy;
                        ball.y = this.ClientSize.Height;
                    }
                    */
                    if (ball.y >= Rock.Ry - ball.D) // Шарик на уровне ракетки (по Y)
                    {
                        // Проверяем, что шарик над ракеткой по X
                        if (ball.x >= Rock.Rx - ball.D / 2
                        && ball.x <= Rock.Rx + Rock.Rw - ball.D / 2)
                        {
                            ball.Vy = -ball.Vy; // Меняем направление скорости
                            ball.y = Rock.Ry - ball.D + ball.Vy;  // Делаем один шаг, иначе на следующем шаге снова сработает условие
                        }
                    }
                    if (ball.y >= this.ClientSize.Height)
                    {
                        MissedBall = ball;
                    }
                    #endregion




                    if (brick.Power == 0)
                    {
                        BrokenBrick = brick;
                        brick.Show(false);
                        //timer1.Stop();
                        //MessageBox.Show("U Won!!!");


                    }
                    else
                    {
                        // Bricks
                        // 1. From Right
                        if (brick != null)
                        {


                            if (ball.y >= brick.y - ball.D / 2
                               && ball.y <= brick.y + brick.h - ball.D / 2
                               && ball.x <= brick.x + brick.w
                               && ball.x >= brick.x + brick.w / 2)
                            {
                                ball.Vx = -ball.Vx;
                                ball.x = brick.x + brick.w + ball.Vx;
                                brick.Power -= 1;
                            }


                            // 2. From Left 

                            if (ball.y >= brick.y - ball.D / 2
                             && ball.y <= brick.y + brick.h - ball.D / 2
                             && ball.x + ball.D >= brick.x
                             && ball.x + ball.D <= brick.x + brick.w / 2)
                            {
                                ball.Vx = -ball.Vx;
                                ball.x = brick.x - ball.D + ball.Vx;
                                brick.Power -= 1;
                            }

                            // 3. From Down 

                            if (ball.x + ball.D / 2 >= brick.x
                               && ball.x + ball.D / 2 <= brick.x + brick.w
                               && ball.y >= brick.y + brick.h / 2
                               && ball.y <= brick.y + brick.h)
                            {
                                ball.Vy = -ball.Vy;
                                ball.y = brick.y + brick.h + ball.Vx;
                                brick.Power -= 1;
                            }

                            // 4. From Up 

                            if (ball.x + ball.D / 2 >= brick.x
                               && ball.x + ball.D / 2 <= brick.x + brick.w
                               && ball.y + ball.D >= brick.y
                               && ball.y + ball.D <= brick.y + brick.h / 2)
                            {
                                ball.Vy = -ball.Vy;
                                ball.y = brick.y - ball.D + ball.Vy;
                                brick.Power -= 1;
                            }
                        }
                    }
                }
                ball.Show(false);
            }
            if(BrokenBrick != null)
            {
                bricks.Remove(BrokenBrick);
                if(bricks.Count == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("U WON!!!");
                }
            }

            if(MissedBall != null)
            {
                BallList.Remove(MissedBall);
                 
                if (BallList.Count == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Comadaidh Fenita la");
                }
            }
           

            if (ArrowLeftHold)
                {
                    if (Rock.Rx - Rock.Vr >= 0)
                    {
                        Rock.Show(false);
                        Rock.Rx -= Rock.Vr;
                        Rock.Show(true);
                    }
                }
                else
                {
                    if (ArrowRightHold)
                    {
                        if (Rock.Rx + Rock.Vr <= this.ClientSize.Width - Rock.Rw)
                        {
                            Rock.Show(false);
                            Rock.Rx += Rock.Vr;
                            Rock.Show(true);
                        }
                    }
                }
            

        }


        private void Squash_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    if (ball.D < 40)
            //    {
            //        ball.D++;
            //    }
            //}
            //else
            //{
            //    if (ball.D > 10)
            //    {
            //        ball.D--;
            //    }
            //}
        }

        private void Squash_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void Squash_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    ArrowLeftHold = true;
                    break;
                case Keys.Right:
                    ArrowRightHold = true;
                    break;
            }
        }

        private void Squash_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    ArrowLeftHold = false;
                    break;
                case Keys.Right:
                    ArrowRightHold = false;
                    break;
            }
        }

    }

    class Ball
    {
        public int x, y;    // Координаты шарика
        public int D;       // Диаметр шарика
        public int Vx, Vy;  // Скорость шарика
 
        public Graphics GDI;
        public Brush BallBrush;
        public Brush EraseBrush;

        public void Show(bool mode)
        {
            if(mode)
            {
                GDI.FillEllipse(EraseBrush, x, y, D, D);
            }
            else
            {
                GDI.FillEllipse(BallBrush, x, y, D, D);
            }
        }
    }


    class Rocket
    {
        public int Rx, Ry; // Координаты ракетки
        public int Vr; // скорость ракетки
        public int Rw, Rh; // Размер



        public Graphics GDI;
        public Brush EraseBrush, RocketBrush;



        public void Show(bool mode)
        {
            //GDI.FillRectangle(EraseBrush, Rx, this.ClientSize.Height - Rh - 2, Rw, Rh);



            if (mode)
            {
                GDI.FillRectangle(RocketBrush, Rx, Ry, Rw, Rh);
            } 
            else
            {
                GDI.FillRectangle(EraseBrush, Rx, Ry, Rw, Rh);
            }
               
        }

    }

    class Brick
    {
        public int Power;
        public int x, y, w, h;
        public Brush PaintBrush, EraseBrush;
        public Graphics GDI;

        public void Show(bool mode)
        {
            if(mode)
            {
                GDI.FillRectangle(PaintBrush, x, y, w, h);
            }
            else
            {
                GDI.FillRectangle(EraseBrush, x, y, w, h);
            }
        }
    }

}
