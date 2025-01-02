using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_250102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region ref,out 실습
            //int[] array;
            //setArray(out array);
            //foreach (int i in array)
            //{
            //    textBox_print.Text += i.ToString()+"\r\n";
            //}
            
            //changearray(ref array);
            //textBox_print.Text += "바꾼 후:";
            //foreach (int i in array)
            //{
            //    textBox_print.Text += i.ToString() + "\r\n";
            //}
            #endregion

            #region 예외처리 실습
            string[] stringLine;
            int[] intLine;
            string path = @"C:\Users\yeeli\input.txt";
            string content = FileOpen(path);
            if (content != "")
            {
                ContenttoLine(out stringLine, out intLine, content);
                textBox_print.Text += "string 타입 : \r\n";
                foreach (string line in stringLine)
                {
                    textBox_print.Text += line;
                }
                textBox_print.Text += "int 타입 : \r\n";
                foreach (int line in intLine)
                {
                    textBox_print.Text += line.ToString() + "\r\n";
                }
            }
            

            #endregion
        }
        #region ref,out 실습
        void setArray(out int[] array)
        {
            int num = 5;
            array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        void changearray(ref int[] array)
        {
            foreach (int i in array)
            {
                array[i] = 2;
            }
        }
        #endregion

        #region 예외처리 실습
        string FileOpen(string path)
        {
            string content = "";
            try
            {
                content = File.ReadAllText(path);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("찾는 파일이 없습니다ㅠㅠ");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return content;
        }
        void ContenttoLine(out string[] stringline, out int[] intline, string content)
        {
            stringline = new string[5];
            intline = new int[5];
            string temp = "";
            int j = 0;
            int k = 0;
            for (int i=0; i<content.Length; i++)
            {
                temp = temp + content[i];
                if (content[i] == '\n')
                {
                    try
                    {
                        int tempint = int.Parse(temp);
                        intline[j] = tempint;
                        j++;
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show(temp+"는 숫자가 아닙니다,,");
                        stringline[k] = temp;
                        k++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + temp);
                        stringline[k] = temp;
                        k++;
                    }
                    finally
                    {
                        MessageBox.Show(temp + "배열에 저장!");
                    }
                    temp = "";
                }
                
            }
            
        }
        #endregion
    }
}
