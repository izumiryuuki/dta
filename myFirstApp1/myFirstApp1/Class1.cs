using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApp1
{
    internal class Class1
    {
        // log(txt)ファイルを入れておく
        private string log;
        public Class1(string path1)
        {
            // インスタンス生成の際にtxtファイルのpathを受け取り
            // 変数へ格納する
            this.log = path1;
        }

        public string getLog()
        {
            return this.log;
        }

        public void setLog(string log)
        {
            this.log = log;
        }


    }
}
