using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_10205
{
    public partial class Form1 : Form
    {
        private Game game;
        private int bx;
        private int by;
        private int bwidth;
        private int bheight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 매번 GameRule에서 가져오기 힘드니 값을 미리 할당해 주는것
            game = Game.Singleton;
            bx = GameRule.BX;
            by = GameRule.BY;
            bwidth = GameRule.B_WIDTH;
            bheight = GameRule.B_HEIGHT;

            SetClientSizeCore(bx * bwidth, by * bheight);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 선 그리기
            DrawLine(e.Graphics);

            // 도형 그리기
            DrawDiagram(e.Graphics);

            DoubleBuffered = true; // 화면 반짝임 해결

            DrawBoard(e.Graphics);
        }

        private void DrawBoard(Graphics graphics)
        {
            for (int xx = 0; xx < bx; xx++)
            {
                for (int yy = 0; yy < by; yy++)
                {
                    if (game[xx, yy] != 0)
                    {
                        Rectangle rectangle = new Rectangle
                        (
                            xx * bwidth,
                            yy * bheight,
                            bwidth - 4,
                            bheight - 4
                        );
                        graphics.DrawRectangle(Pens.BurlyWood, rectangle);
                        graphics.FillRectangle(Brushes.BurlyWood, rectangle);
                    }
                }
            }
        }

        private void DrawLine(Graphics graphics)
        {
            DrawHorizons(graphics); // 수평선 그리기 
            DrawVerticals(graphics); // 수직선 그리기 
        }

        private void DrawHorizons(Graphics graphics)
        {
            Point sp = new Point(); // 시작 점
            Point ep = new Point(); // 끝 점

            for (int cy = 0; cy < by; cy++)
            {
                // sp
                sp.X = 0;
                sp.Y = cy * bheight;

                // ep
                ep.X = bx * bwidth;
                ep.Y = sp.Y;

                graphics.DrawLine(Pens.DeepPink, sp, ep);
            }
        }

        private void DrawVerticals(Graphics graphics)
        {
            Point sp = new Point(); // 시작 점
            Point ep = new Point(); // 끝 점

            for (int cx = 0; cx < bx; cx++)
            {
                // sp
                sp.X = cx * bwidth;
                sp.Y = 0;

                // ep
                ep.X = sp.X;
                ep.Y = bheight * by;

                graphics.DrawLine(Pens.DeepPink, sp, ep);
            }
        }

        private void DrawDiagram(Graphics graphics)
        {
            Pen pen = new Pen(Color.BlueViolet, 4);
            Point now = game.nowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;

            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rectangle = new Rectangle
                            (
                            (now.X + xx) * bwidth + 2,
                            (now.Y + yy) * bheight + 2,
                            bwidth - 4,
                            bheight - 4
                            );
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: MoveLeft(); return;
                case Keys.Right: MoveRight(); return;
                case Keys.Space: MoveDown(); return;
                case Keys.Up: MoveTurn(); return;
                case Keys.Down: MoveSSDown(); return;
            }
        }

        private void MoveSSDown()
        {
            while (game.CanMoveDown())
            {
                Region region = MakeRegion(0, -1);
                Invalidate(region);
            }
            EndingCheck();
        }

        private void MoveLeft()
        {
            if (game.CanMoveLeft())
            {
                // 매개 변수로 이동 전 내 위치를 나타냄
                Region region = MakeRegion(1, 0);

                // 무효화
                Invalidate(region);
            }
        }

        private void MoveRight()
        {
            if (game.CanMoveRight())
            {
                // 매개 변수로 이동 전 내 위치를 나타냄
                Region region = MakeRegion(-1, 0);

                // 무효화
                Invalidate(region);
            }
        }

        private void MoveDown()
        {
            if (game.CanMoveDown())
            {
                // 매개 변수로 이동 전 내 위치를 나타냄
                Region region = MakeRegion(0, -1);

                // 무효화
                Invalidate(region);
            }
            else
            {
                EndingCheck();
            }
        }

        private void EndingCheck()
        {
            if (game.CanNext()) // 다음 도형이 나올 시 게임 진행이 가능한 경우
            {
                Invalidate();
            }
            else // 게임 오버일 겅우
            {
                timer_Down.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("다시하기", "다시하기 여부", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    game.Restart();
                    timer_Down.Enabled = true;
                    Invalidate();
                }
                else
                    Close();
            }
        }

        private Region MakeRegion(int v1, int v2)
        {
            Point now = game.nowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;

            Region region = new Region(); // 영역 변수
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        // 이동 후 도형을 구성하는 사각형 
                        Rectangle rectangle3 = new Rectangle
                            (
                                (now.X + xx) * bwidth,
                                (now.Y + yy) * bheight,
                                bwidth,
                                bheight
                            );

                        // 이동 전 도형을 구성하는 사각형 
                        Rectangle rectangle4 = new Rectangle
                        (
                            (now.X + xx + v1) * bwidth,
                            (now.Y + yy + v2) * bheight,
                            bwidth,
                            bheight
                        );
                        Region region1 = new Region(rectangle3);
                        Region region2 = new Region(rectangle4);
                        region.Union(rectangle3);
                        region.Union(rectangle4);
                    }
                }
            }
            return region;
            //Rectangle rectangle1 = new Rectangle(now.X * bwidth, now.Y * bheight, bwidth, bheight); // 현재 사각형
            //Rectangle rectangle2 = new Rectangle((now.X + v1) * bwidth, (now.Y + v2) * bheight, bwidth, bheight); // 이동 전 사각형

            //Region region1 = new Region(rectangle1);
            //Region region2 = new Region(rectangle2);
            //rectangle1.Union(rectangle2);

            //return rectangle1;
        }

        private Region MakeRegion() // 회전 전/후 영역을 구하는 메서드 (영역전개)
        {
            Point now = game.nowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;
            int oldth = (tn + 3) % 4;

            Region region = new Region();

            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rectangle = new Rectangle
                            (
                                (now.X + xx) * bwidth,
                                (now.Y + yy) * bheight,
                                bwidth,
                                bheight
                            );
                        Region region1 = new Region(rectangle);
                        region.Union(region1);
                    }

                    if (BlockValue.bvals[bn, oldth, xx, yy] != 0)
                    {
                        Rectangle rectangle = new Rectangle
                            (
                                (now.X + xx) * bwidth,
                                (now.Y + yy) * bheight,
                                bwidth,
                                bheight
                            );
                        Region region1 = new Region(rectangle);
                        region.Union(region1);
                    }
                }
            }
            return region;
        }

        private void MoveTurn()
        {
            if (game.CanMoveTurn())
            {
                Region region = MakeRegion();
                Invalidate(region);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveDown();
        }
    }
}