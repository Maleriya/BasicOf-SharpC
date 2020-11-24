using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ElenaNedorezovaLesson08_HW03
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string text;
        public bool trueFalse;

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }

    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public bool Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            bool success = true;
            try
            {
                list = (List<Question>)xmlFormat.Deserialize(fStream);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"С чтением файла что-то не так {ex.Message}","Ошибка");
                success = false;  
            }
            finally
            {
                fStream.Close();
            }

            return success;
        }
        public int Count
        {
            get { return list.Count; }
        }
    }

}
