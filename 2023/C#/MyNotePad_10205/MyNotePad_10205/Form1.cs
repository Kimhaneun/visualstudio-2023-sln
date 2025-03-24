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

namespace MyNotePad_10205
{
    public partial class Form1 : Form
    {
        bool modifyFlag = false; // 수정 사항이 있는가?
        string fileName = "noname.txt"; // 파일의 이름
        
        public Form1() // 생성자
        {
            InitializeComponent();
            this.Text = fileName + " - myNotePad_10205";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // 텍스트가 변경되면 실행되는 이벤트
        {
            modifyFlag = true; // 파일에 수정 사항이 있어
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforeClose();
            richTextBox1.Text = "";
            modifyFlag = false;
            fileName = "noname.txt";
        }

        private void BeforeClose() // 수정된 상태에서 파일을 종료할 때
        {
            if (modifyFlag) // 파일에 수정 사항이 있다면?
            {
                DialogResult answer = MessageBox.Show("변경 내용을 저장하겠습니까?", "저장 여부", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    if (fileName == "noname.text") // 파일 이름이 없는 경우 
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter streamwriter = File.CreateText(saveFileDialog1.FileName);
                            streamwriter.WriteLine(richTextBox1.Text);
                            streamwriter.Close();
                        }
                    }

                    else // 파일 이름이 존재 한다면
                    {
                        StreamWriter streamWriter = File.CreateText(fileName);
                        streamWriter.Write(richTextBox1.Text);
                        streamWriter.Close();
                    }
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforeClose();

            // onenfildialog.showdialog.fileName;
            this.Text = fileName + " - myNotePad_10205";

            try
            {
                StreamReader streamReader = File.OpenText(fileName);
                richTextBox1.Text = streamReader.ReadToEnd();

                modifyFlag = false;
                streamReader.Close();
            }

            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforeClose();
            Close();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "noname.txt")
            {
                saveFileDialog1.ShowDialog();
                fileName = saveFileDialog1.FileName;
            }

            StreamWriter writer = File.CreateText(fileName);
            writer.WriteLine(richTextBox1.Text);
            writer.Close();

            modifyFlag = false;
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;

            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
            }
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;

            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                modifyFlag = true;
            }
        }
    }
}
