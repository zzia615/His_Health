using System;
using System.Collections.Generic;
using System.Text;
namespace Jaylosy.Kernel.File
{
    public class FileManager
    {
        public void WriteText(string fileName,string content)
        {
            if (!System.IO.File.Exists(fileName))
            {
                System.IO.File.Create(fileName).Close();
            }
            var fs = System.IO.File.OpenWrite(fileName);
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }
    }
}
