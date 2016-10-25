using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestsApp.Model
{
    [Serializable]
    public class Question
    {
        [DisplayName("Текст вопроса")]
        public string QuestionText { get; set; }
        private List<string> _optionsText;
        private int _correctAnswerIndex;
        private int _maxCount = 5;

        [DisplayName("Номер правильного ответа")]
        public int CorrectAnswerIndex
        {
            get
            {
                return _correctAnswerIndex + 1;
            }
            set
            {
                if (_optionsText == null || !IndexesCorrectionCheck())
                    throw new ArgumentException("Invalid answer index");
            }
        }

        public List<string> OptionsText
        {
            get
            {
                return _optionsText;
            }
            set
            {
                if(!IndexesCorrectionCheck())
                    throw new ArgumentOutOfRangeException($"Invalid options list");
            }
        }

        private bool IndexesCorrectionCheck()
        {
            return (_correctAnswerIndex > _optionsText.Count - 1 || _correctAnswerIndex < 0);
        }

        public Question(string buildQuestionText, int buildAnswerIndex, params string[] buildAnswers)
        {

            QuestionText = buildQuestionText;
            _correctAnswerIndex = buildAnswerIndex;
            _optionsText = new List<string>(buildAnswers);
        }

        public bool CheckAnswer(int inputIndex)
        {
            return inputIndex == _correctAnswerIndex;
        }

        public void AddAnswer(string newAnswer)
        {
            if (_optionsText.Count == 5) throw new Exception("Too much options");
            OptionsText.Add(newAnswer);
        }
    }
}
