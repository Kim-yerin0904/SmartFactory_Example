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

namespace example_241220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MakeResultSentence (string studentName, int koreanScore, int englishScore, int mathScore)
        {
            textBoxResult.Text += studentName + "\r\n";
            textBoxResult.Text += "국어 :" + koreanScore + "/ 영어 :" + englishScore + "/ 수학 :" + mathScore + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            textBoxResult.Text = "";
            int studentCount = 0;
            int[,] scoreTable = new int[studentCount, 3];
            // 숫자가 아닌 경우 예외 처리 (TryParse는 out 변수로 값이 들어감)
            if (int.TryParse(textBoxInput.Text, out studentCount))
            {
                Random rand = new Random();
                for (int i = 1; i < studentCount + 1; i++)
                {
                    int koreanScore = rand.Next(101);
                    int englishScore = rand.Next(101);
                    int mathScore = rand.Next(101);
                    string studentName = "학생" + i.ToString();
                    MakeResultSentence(studentName, koreanScore, englishScore, mathScore);
                    dataGridView1.Rows.Add(studentName, koreanScore, englishScore, mathScore);
                }
            }
            else
            {
                textBoxResult.Text = "숫자만 입력해 주세요!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 파일 |*.csv|모든 파일|*.*";
            saveFileDialog.FilterIndex = 1;
            // 대화상자를 닫기 전에 디렉토리를 이전에 선택한 디렉토리로 복원한지의 여부를 나타냄
            saveFileDialog.RestoreDirectory = true;
            // 확장명을 입려하지 않을 경우, 자동으로 csv로 지정
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "csv";
            // 파일이 이미 존재하면 덮어쓰기를 할지 묻는 대화상자 표시 기본값=true
            saveFileDialog.OverwritePrompt = true;
            // 저장할 위치의 초기 디렉토리 설정
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataGridViewToCSV(saveFileDialog.FileName, dataGridView1, true);
            }
        }
        private void DataGridViewToCSV(string fileName, DataGridView dgview, bool header)
        {
            string delimiter = ","; //구분자

            //파일읽기 쓰기 방법
            //FileMode.Creat : 새 파일 생성
            //FileAccess.Write : 파일 쓰기 권한
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter csvExport = new StreamWriter(fs, Encoding.UTF8);

            if (dgview.Rows.Count == 0) return;

            // header 포함
            if (header)
            {
                for (int i = 0; i < dgview.Columns.Count; i++)
                {
                    csvExport.Write(dgview.Columns[i].HeaderText);
                    if (i != dgview.Columns.Count - 1)
                    {
                        csvExport.Write(delimiter);
                    }
                }
            }
            csvExport.Write(csvExport.NewLine); //add new line

            //데이터 출력
            foreach (DataGridViewRow row in dgview.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgview.Columns.Count; i++)
                    {
                        csvExport.Write(row.Cells[i].Value);
                        if (i != dgview.Columns.Count - 1)
                        {
                            csvExport.Write(delimiter);
                        }
                    }
                    csvExport.Write(csvExport.NewLine); //write new line
                }
            }
            csvExport.Flush();
            csvExport.Close();
            fs.Close();

            MessageBox.Show("CSV 파일 저장 완료!");
        }
    }
}

