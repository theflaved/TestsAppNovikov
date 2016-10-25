using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsApp.Model
{
    [Serializable]
    public class QuestionFile
    {
        public List<Question> QuestionList;
        public int QuestionCount => QuestionList.Count;
        public string Password;

        public QuestionFile()
        {
            QuestionList = new List<Question>();
        }

        public void AddQuestion(Question toAdd) => QuestionList.Add(toAdd);

        public bool Save()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Test File|*.tst";
            dialog.Title = "Сохранить тест";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(dialog.FileName, FileMode.Create);
                formatter.Serialize(fs,this);
                fs.Close();
                return true;
            }
            return false;
        }

        public bool Load()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Test File|*.tst";
            dialog.Title = "Открыть тест";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(dialog.FileName, FileMode.Open);
                QuestionFile temp = (QuestionFile)formatter.Deserialize(fs);
                QuestionList = temp.QuestionList;
                Password = temp.Password;
                fs.Close();
                return true;
            }
            return false;
        }

    }
}
