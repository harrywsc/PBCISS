using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBCISS
{
    class Util
    {
        public void ReadData(string path, string[] cashData)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    String line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cashData[i] = line.ToString().Split('|')[0];
                        cashData[i + 1] = line.ToString().Split('|')[1];
                        i = i + 2;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("出现异常：" + e);

            }
        }

        public static void AddDept(string deptName)
        {
            string startupPath = Application.StartupPath + "//Data";
            if (!Directory.Exists(startupPath))
            {
                Directory.CreateDirectory(startupPath);
            }
            if (!File.Exists(startupPath+"//Dept.txt"))
            {
                File.Create(startupPath);
            }

            using (FileStream fs = new FileStream(startupPath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    sw.WriteLine("aaaaa");
                    sw.WriteLine("bbbbb");
                    sw.Flush();
                    sw.WriteLine("ccccc");

                }
            }


        }
    }

}
