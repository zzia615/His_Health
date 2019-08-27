using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Jaylosy.Kernel.File
{
    public class FileManager
    {
        public void CreateDir(string dir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            if (!directoryInfo.Exists)
            {
                if (!directoryInfo.Parent.Exists)
                {
                    CreateDir(directoryInfo.Parent.FullName);
                }
                else
                {
                    return;
                }
                directoryInfo.Create();
            }
        }

        public void SaveFile(string saveFileName,byte[] bytes)
        {
            FileStream fs = System.IO.File.Open(saveFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();
        }

        public void SaveFile(string saveFileName, Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            FileStream fs = System.IO.File.Open(saveFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();
        }

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
