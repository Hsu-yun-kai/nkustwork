using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work.Services
{
    public class ImpotXmlservice
    {
        /*private int count; //全域變數        
        public ImpotXmlservice(int count) 
        {
            this.count = count;
        }*/

        public ImpotXmlservice() { }
        public  List<Object> LoadFormFile(string filePath)      //給一個檔案路徑回一個陣列
            {
                //System.IO.FileInfo fi = new System.IO.FileInfo(filePath);   //開啟檔案
                //fi.~~~

                var str = System.IO.File.ReadAllText(filePath);

                var xDocument =  System.Xml.Linq.XDocument.Parse(str);                   //靜態讀取
                //System.Xml.Linq.XDocument xDocument = new System.Xml.Linq.XDocument();    

                var targets = xDocument.Descendants("StationExit");

            

                return null;
            }
    }
}
