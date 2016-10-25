using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsApp.Model;

namespace TestsApp
{
    public partial class EditQuestionForm : Form
    {
        private List<Question> _workingList;
        private bool _editFlag;
        private int _editIndex;
        private RadioButton[] _radioList;
        private TextBox[] _answerBoxes;
        public EditQuestionForm(List<Question> workingList)
        {
            InitializeComponent();
            _workingList = workingList;
            _editFlag = false;
            _radioList = new[]
                {TrueButton1, TrueButton2, TrueButton3, TrueButton4, TrueButton5};
            _answerBoxes = new[]
                {AnswerText1, AnswerText2, AnswerText3, AnswerText4, AnswerText5};
            AnswerQuanity.Value = AnswerQuanity.Maximum;
        }

        public EditQuestionForm(List<Question> workingList, int index)
        {
            InitializeComponent();
            _workingList = workingList;
            _editFlag = true;
            _editIndex = index;
            _radioList = new[]
                {TrueButton1, TrueButton2, TrueButton3, TrueButton4, TrueButton5};

            _answerBoxes = new[]
                {AnswerText1, AnswerText2, AnswerText3, AnswerText4, AnswerText5};

            Question selectedQuestion = _workingList[_editIndex];

            QuestionBox.Text = selectedQuestion.QuestionText;
            AnswerQuanity.Value = selectedQuestion.OptionsText.Count;
            _radioList[selectedQuestion.CorrectAnswerIndex - 1].Checked = true;
            for (int i = 0; i < selectedQuestion.OptionsText.Count; i++)
            {
                _answerBoxes[i].Text = selectedQuestion.OptionsText[i];
            }       

        }

        private void AnswerQuanity_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < AnswerQuanity.Maximum; i++)
            {
                _answerBoxes[i].Enabled = true;
                _radioList[i].Enabled = true;
            }
            for (int i = AnswerQuanity.Value; i < AnswerQuanity.Maximum; i++)
            {
                _answerBoxes[i].Enabled = false;
                _radioList[i].Enabled = false;
            }
            TrueButton1.Checked = true;
        }

        private int CheckedIndex(RadioButton[] rx)
        {
            for(int i = 0; i < rx.Length; i++)
            {
                if (rx[i].Checked) return i;
            }
            return -1;
        }

        private string[] GetTextFromTextBoxes(TextBox[] tx)
        {
            string[] result = new string[AnswerQuanity.Value];
            for (int i = 0; i < AnswerQuanity.Value; i++)
            {
                result[i] = _answerBoxes[i].Text;
            }
            return result;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(_editFlag) _workingList[_editIndex] = 
                    new Question(QuestionBox.Text,CheckedIndex(_radioList),
                    GetTextFromTextBoxes(_answerBoxes));
            else
            {
                _workingList.Add(
                    new Question(QuestionBox.Text, CheckedIndex(_radioList),
                    GetTextFromTextBoxes(_answerBoxes)));
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
