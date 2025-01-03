using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;


namespace example_250103
{
    public partial class Form1 : Form
    {

        IDictionary<string, string> idpw = new Dictionary<string, string>();
        IDictionary<string, string> idpn = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fileopen_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 열기";

            //파일 오픈창 로드
            DialogResult result = ofd.ShowDialog();
            string filepath;
            //ok버튼 클릭시
            if (result == DialogResult.OK)
            {
                filepath = ofd.FileName;
            }
            else
            {
                filepath = "";
            }

            // 파일 열어서 읽고 한줄씩 딕셔너리에 저장
            try
            {
                var sr = new StreamReader(filepath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] inform = line.Split(',');
                    idpw.Add(inform[0], inform[1]);
                    try
                    { 
                        idpn.Add(inform[0], inform[2]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        idpn.Add(inform[0], null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("파일을 찾을 수 없습니다ㅠㅠ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "" && textBox_pw.Text != "")
            {
                if (idpw.TryGetValue(textBox_id.Text, out string pw))
                {
                    if (idpw[textBox_id.Text] == pw)
                    {
                        MessageBox.Show($"로그인 성공! 아이디:{textBox_id.Text} 전화번호:{idpn[textBox_id.Text]}");
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패.. 비밀번호가 틀렸습니다...");
                    }
                }
                else
                {
                    MessageBox.Show("로그인 실패.. 존재하지 않는 아이디입니다..");
                }
            }
            else
            {
                MessageBox.Show("로그인 실패.. 아이디와 비밀번호를 입력해주세요!");
            }
        }
    }
}
