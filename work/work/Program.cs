using System;
using work.Services;

namespace work
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var xmlService = new ImpotXmlservice();   //搬動藍圖到基底程式

            var datas = xmlService.LoadFormFile(@"C:\Users\user\OneDrive\文件\nkustwork\docs\臺中市路邊停車收費路段.xml");



            Console.WriteLine("Hello World!");
            
        }

    }
}
