using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_Kostin
{
    public partial class Form1
    {
        bool checkCorrectChoise(string path, string id)
        {
            bool result = false;
            
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].folderPath == path && arr[i].usbID == id)
                {
                    result = true; 
                    break; 
                }
            }
            return result;
        }

        void writeDataToFile()
        {
            string data = "";
            for (int i = 0; i < arr.Count; i++) {
                data += arr[i].folderPath + '\n';
                data += arr[i].usbID + '\n';
            }
            File.WriteAllText("data", data);
        }

        void readDataFromFile()
        {
            if (File.Exists("data")) {
                StreamReader streamReader = new StreamReader("data");
                List<Folder> newArr = new List<Folder>();
                Folder temp = new Folder();
                while (!streamReader.EndOfStream)
                {
                    temp.folderPath = streamReader.ReadLine();
                    temp.usbID = streamReader.ReadLine();
                    newArr.Add(temp);
                }
                streamReader.Close();
                arr = newArr;
            }
        }

        bool checkFolderRepeat(string path)
        {
            bool result = false;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].folderPath == path)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        bool thatFolderIsLocked(string path)
        {
            bool result = false;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].folderPath == path)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        void removeFolderFromArr(string path)
        {
            List<Folder> newArr = new List<Folder>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].folderPath != path) 
                    newArr.Add(arr[i]);
            }
            arr = newArr;
        }
    }
}
