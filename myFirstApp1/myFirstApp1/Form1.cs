using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myFirstApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string path1 = "ボタンが押されました";

            using (StreamWriter sw = new StreamWriter(@"C:\Users\salva\デスクトップ\sample\c# 勉強用\test.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("おはようございます");
            }

            Class1 cls1 = new Class1(path1);
            
            label1.Text = cls1.getLog();
            

            
        }
    }
}
