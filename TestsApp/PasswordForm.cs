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
    public partial class PasswordForm : Form
    {
        private bool _createFlag;
        private QuestionFile _workingFile;
        public PasswordForm(bool constructCreateFlag = false)
        {
            InitializeComponent();
            _createFlag = constructCreateFlag;
            _workingFile = new QuestionFile();
            if (!_createFlag) _workingFile.Load();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (!_createFlag)
            {
                if (PasswordBox.Text != _workingFile.Password)
                {
                    MessageBox.Show("Неверный пароль, проверьте правильность ввода и повторите попытку.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _workingFile.Password = PasswordBox.Text;
            }
            MainEditWindow form = new MainEditWindow(_workingFile);
            Hide();
            form.ShowDialog();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
