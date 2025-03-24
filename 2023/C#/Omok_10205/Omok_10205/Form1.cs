using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 뵤!!!

namespace Omok_10205
{
    enum STONE { none, black, white };
    public partial class Form1 : Form
    {

        #region STATE PARAMETERS
        // int
        int margin = 40;
        int nungeumSize = 30;
        int dolSize = 28;
        int hwajeomSize = 10;
        int stoneCnt = 1; // 수순
        int sequence = 0;

        Graphics Graphics;
        Pen Pen;
        Brush BBrush, WBrush;
        Font Font = new Font("맑은 고딕", 10);
        List<Revive> lsttRevive = new List<Revive>();

        // bool
        bool imageFlag = false; // f: 그리기, t: 이미지
        bool sequenceFlag = false; // f: 숫자 표시 없음 t: 숫자 표시 있음
        bool reviveFlag = false; // f: 일반 게임 모드 t: 복기 모드 

        // string
        string dirName;
        #endregion

        STONE[,] badugpan = new STONE[19, 19];
        bool flag = false; // f: 검은 돌 t: 휜 돌

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard();
            DrawStones();
        }

        private void DrawStones()
        {
            for (int x = 0; x < 19; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    Rectangle rectangle = new Rectangle(
                        margin + x * nungeumSize - dolSize / 2,
                        margin + y * nungeumSize - dolSize / 2,
                        dolSize, dolSize);
                    if (badugpan[x, y] == STONE.white)
                    {
                        if (imageFlag == false)
                        {
                            Graphics.FillEllipse(WBrush, rectangle); // FillEllipse: 타원형으로 그려주는 메서드
                        }
                        else
                        {
                            Bitmap bitmap = new Bitmap("../../Images/White.png");
                            Graphics.DrawImage(bitmap, rectangle);
                        }
                    }

                    else if (badugpan[x, y] == STONE.black)
                    {
                        if (imageFlag == false)
                        {
                            Graphics.FillEllipse(BBrush, rectangle);
                        }
                        else
                        {
                            Bitmap bitmap = new Bitmap("../../Images/Black.png");
                            Graphics.DrawImage(bitmap, rectangle);
                        }
                    }
                }
            }
        }

        void DrawBoard()
        {
            Graphics = panel1.CreateGraphics();

            // 바둑판 줄 긋기
            for (int i = 0; i < 19; i++)
            {
                // 세로 선
                Graphics.DrawLine(Pen,
                    new Point(margin + i * nungeumSize, margin), // 시작 점
                    new Point(margin + i * nungeumSize, margin + 18 * nungeumSize)); // 끝 점

                // 가로 선
                Graphics.DrawLine(Pen,
                    new Point(margin, margin + i * nungeumSize), // 시작 점
                    new Point(margin + 18 * nungeumSize, margin + i * nungeumSize)); // 끝 점
            }

            // 화점 그리기
            for (int x = 3; x <= 15; x += 6)
            {
                for (int y = 3; y <= 15; y += 6)
                {
                    Graphics.FillEllipse(BBrush,
                        margin + nungeumSize * x - hwajeomSize / 2,
                        margin + nungeumSize * y - hwajeomSize / 2,
                        hwajeomSize, hwajeomSize // 화점의 크기
                        );
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (reviveFlag == true)
            {
                ReviveGame();
                return;
            }

            // 바둑판 좌표로 변경
            int x = (e.X - margin + nungeumSize / 2) / nungeumSize;
            int y = (e.Y - margin + nungeumSize / 2) / nungeumSize;

            if (badugpan[x, y] != STONE.none) // 놓으려는 위치에 돌이 위치할 경우
                return;

            Rectangle rectangle = new Rectangle(
                margin + nungeumSize * x - dolSize / 2,
                margin + nungeumSize * y - dolSize / 2,
                dolSize, dolSize);

            if (flag == false)
            {
                if (imageFlag == false)
                {
                    Graphics.FillEllipse(BBrush, rectangle);
                }
                else
                {
                    Bitmap bitmap = new Bitmap("../../Images/Black.png");
                    Graphics.DrawImage(bitmap, rectangle);
                }
                lsttRevive.Add(new Revive(x, y, STONE.black, stoneCnt));
                DrawStoneSequence(stoneCnt++, Brushes.White, rectangle);
                flag = true;
                badugpan[x, y] = STONE.black;
            }
            else
            {
                if (imageFlag == false)
                {
                    Graphics.FillEllipse(WBrush, rectangle);
                }
                else
                {
                    Bitmap bitmap = new Bitmap("../../Images/White.png");
                    Graphics.DrawImage(bitmap, rectangle);
                }
                lsttRevive.Add(new Revive(x, y, STONE.white, stoneCnt));
                DrawStoneSequence(stoneCnt++, Brushes.Black, rectangle);
                flag = false;
                badugpan[x, y] = STONE.white;
            }

            OmokCheck(x, y);
        }

        private void ReviveGame()
        {
            if (sequence < lsttRevive.Count)
            {
                DrawStones(lsttRevive[sequence++]);
            }
        }

        private void DrawStones(Revive revive)
        {
            int x = revive.x;
            int y = revive.y;

            STONE sTONE = revive.Stone;
            int seq = revive.Seq;

            Rectangle rectangle = new Rectangle(margin + x * nungeumSize - dolSize / 2,
                margin + y * nungeumSize - dolSize / 2,
                dolSize, dolSize);

            if (sTONE == STONE.black)
            {
                if (imageFlag == false)
                {
                    Graphics.FillEllipse(BBrush, rectangle);
                }
                else
                {
                    Bitmap bitmap = new Bitmap("../../Images/Black.png");
                    Graphics.DrawImage(bitmap, rectangle);

                }
            } 
        }

        private void DrawStoneSequence(int v, Brush color, Rectangle rectangle)
        {
            if (sequenceFlag == true)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                Graphics.DrawString(v.ToString(), Font, color, rectangle, stringFormat);
            }
        }

        private void OmokCheck(int x, int y)
        {
            int cnt = 1;
            #region WIDTH
            // Left
            for (int i = x - 1; i >= 0; i--)
            {
                if (badugpan[x, y] == badugpan[i, y])
                    cnt++;
                else
                    break;
            }

            // Right
            for (int i = x + 1; i <= 18; i++)
            {
                if (badugpan[x, y] == badugpan[i, y])
                    cnt++;
                else
                    break;
            }

            if (cnt >= 5f)
            {
                OmokOver(x, y);
                return;
            }
            #endregion

            cnt = 1;
            #region LENGTH
            // Up
            for (int i = y - 1; i >= 0; i--)
            {
                if (badugpan[x, y] == badugpan[x, i])
                    cnt++;
                else
                    break;
            }

            // Down
            for (int i = y + 1; i <= 18f; i++)
            {
                if (badugpan[x, y] == badugpan[x, i])
                    cnt++;
                else
                    break;
            }

            if (cnt >= 5f)
            {
                OmokOver(x, y);
                return;
            }
            #endregion

            cnt = 1;
            #region DIAGONAL_0
            // Left Down
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18f; i--, j++)
            {
                if (badugpan[x, y] == badugpan[i, j])
                    cnt++;
                else
                    break;
            }

            // Right Up
            for (int i = x + 1, j = y - 1; i <= 18f && j >= 0; i++, j--)
            {
                if (badugpan[x, y] == badugpan[i, j])
                    cnt++;
                else
                    break;
            }

            if (cnt >= 5f)
            {
                OmokOver(x, y);
                return;
            }
            #endregion

            cnt = 1;
            #region DIAGONAL_1
            // Left Up
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (badugpan[x, y] == badugpan[i, j])
                    cnt++;
                else
                    break;
            }

            // Right Down
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (badugpan[x, y] == badugpan[i, j])
                    cnt++;
                else
                    break;
            }

            if (cnt >= 5f)
            {
                OmokOver(x, y);
                return;
            }
            #endregion
        }

        private void OmokOver(int x, int y)
        {
            SaveGame();
            DialogResult result = MessageBox.Show(badugpan[x, y].ToString() + " 승리 \n다시하기",
                "게임 종료", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                this.Close();
            else if (result == DialogResult.Yes)
                NewGame();
        }

        private void SaveGame()
        {
            if (reviveFlag == true)
                return;


            string documentPath = Path.Combine(
                Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents").ToString();

            documentPath += @"\Omok_10205\";

            if (!Directory.Exists(documentPath))
                Directory.CreateDirectory(documentPath);

            string fileName = documentPath + DateTime.Now.ToShortDateString() + "-" +
                DateTime.Now.Hour + DateTime.Now.Minute + ".txt";

            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            foreach (Revive item in lsttRevive)
            {
                streamWriter.WriteLine($"{item.x} {item.y} {item.Stone} {item.Seq}");
            }

            streamWriter.Close();
            fileStream.Close();
        }

        private void NewGame()
        {
            imageFlag = false;
            flag = false;
            reviveFlag = false;
            stoneCnt = 1;

            ClearBoard();

            panel1.Refresh();
            DrawBoard();
        }

        private void 그리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFlag = false;
        }

        private void 이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFlag = true;
        }

        private void 수순표시ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sequenceFlag = true;
        }

        private void 수순표시없음ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sequenceFlag = false;
        }

        private void 복기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = dirName; // 파일 경로 설정
            openFileDialog.Filter = "OMok files(*.omk)|*.omk"; // 파일 필터 설정
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            sequenceFlag = true;

            // 현재 게임 중 이라면 초기화 
            InitializeOmok();

            // 파일 읽기
            try
            {
                StreamReader streamReader = File.OpenText(fileName);
                string line = "";

                while ((line = streamReader.ReadLine()) != null) // 한 줄 씩 읽어 오게 
                {
                    string[] items = line.Split(' '); // 띄어 쓰기를 기준으로
                    Revive revive = new Revive(int.Parse(items[0]),
                        int.Parse(items[1]),
                        items[2] == "black" ? STONE.black : STONE.white,
                        int.Parse(items[3])
                        );

                    lsttRevive.Add(revive);
                }
                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reviveFlag = true;
            sequence = 0;
        }

        private void InitializeOmok()
        {
            flag = false;
            reviveFlag = false;

            // 만약 게임을 진행 중 인데 복기 모드를 사용하면
            lsttRevive.Clear(); 
            stoneCnt = 1;
            ClearBoard();
            panel1.Refresh();
            DrawBoard();
        }

        private void ClearBoard()
        {
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    badugpan[x, y] = STONE.none;
        }

        private void 다시시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeOmok();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;

            Pen = new Pen(Color.Black);
            BBrush = new SolidBrush(Color.Black);
            WBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * nungeumSize,
                2 * margin + 18 * nungeumSize + menuStrip1.Height); // 정사각형
        }
    }
}
