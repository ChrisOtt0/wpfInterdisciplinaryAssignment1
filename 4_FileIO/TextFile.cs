using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfInterdisciplinaryAssignment1.Foundation;

namespace wpfInterdisciplinaryAssignment1.FileIO
{
    public class TextFile : FileAdapter
    {
        const string PROJECTPATH = "D:\\Datamatik\\Coding\\C#\\Windows\\3. Semester\\TextClassification\\TextClassification\\bin\\Debug\\";

        const string FOLDERA = "ClassA";
        const string FOLDERB = "ClassB";
        public TextFile(string fileType) : base(fileType)
        {

        }
        public override List<string> GetAllFileNames(string folderName)
        {
            List<string> fileNames = new List<string>();
            string[] paths = Directory.GetFiles(PROJECTPATH + folderName, "*." + GetFileType());

            foreach (string path in paths)
            {
                fileNames.Add(path);
            }
            return fileNames;
        }

        public string GetFilePathA(string fileName)
        {
            return @PROJECTPATH + FOLDERA + "\\" + fileName + "." + base.GetFileType();
        }

        public override string GetAllTextFromFileA(string path)
        {
            string text = File.ReadAllText(path);

            return text;
        }

        public override string GetAllTextFromFileB(string path)
        {
            string text = File.ReadAllText(path);

            return text;
        }
    }
}
