using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsApp.Model;

namespace TestsApp
{
    public partial class MainTestWindows : Form
    {
        private QuestionFile _questionBank;
        private int _nowIndex;
        private RadioButton[] RadioButtonList;
        private int CorrectAnswers;
        public MainTestWindows()
        {
            InitializeComponent();
            _questionBank = new QuestionFile();
            RadioButtonList = new[] { Answer1, Answer2, Answer3, Answer4, Answer5 };
            _nowIndex = 0;
            CorrectAnswers = 0;
            QuestionBox.ReadOnly = true;
        }

        private void MainTestWindows_Load(object sender, EventArgs e)
        {
            INITIALIZER();
        }

        private bool INITIALIZER()
        {
            if(!_questionBank.Load() || _questionBank.QuestionCount == 0)
            {
                MessageBox.Show("Тест поврежден или не содержит вопросов!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return false;
            }
            TextWriter();
            return true;
        }
        public void GetToNextQuestion()
        {
            CheckIfCorrectAnswer();
            _nowIndex++;
            if (_nowIndex == _questionBank.QuestionList.Count)
            {
                TestEnd();
                return;
            }
            TextWriter();
        }

        private void TextWriter()
        {
            QuestionBox.Text = _questionBank.QuestionList[_nowIndex].QuestionText;
            foreach (RadioButton button in RadioButtonList)
            {
                button.Visible = false;
            }
            for (int i = 0; i < _questionBank.QuestionList[_nowIndex].OptionsText.Count; i++)
            {
                RadioButtonList[i].Text = _questionBank.QuestionList[_nowIndex].OptionsText[i];
                RadioButtonList[i].Visible = true;
            }
            QuestionIndexLabel.Text = (_nowIndex + 1) + "/" + _questionBank.QuestionCount;
        }

        private void TestEnd()
        {
            MessageBox.Show(CorrectAnswers.ToString() + "/" + _questionBank.QuestionCount, "Правильных ответов");
            Close();
        }

        public bool CheckIfCorrectAnswer()
        {
            for (int i = 0; i < RadioButtonList.Length; i++)
            {
                if (RadioButtonList[i].Checked && _questionBank.QuestionList[_nowIndex].CorrectAnswerIndex - 1 == i)
                {
                    CorrectAnswers++;
                    MessageBox.Show("Ответ правильный", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    return true;
                }
            }
            MessageBox.Show("Ответ не верен", "Плохо!", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            return false;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            GetToNextQuestion();
        }

        private void EndItButton_Click(object sender, EventArgs e)
        {
            TestEnd();
        }
    }
}
