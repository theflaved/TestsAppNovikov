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
    public partial class MainEditWindow : Form
    {
        private QuestionFile _workingFile;
        public MainEditWindow(QuestionFile file)
        {
            InitializeComponent();
            _workingFile = file;
            QuestionsGridView.DataSource = _workingFile.QuestionList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditQuestionForm form = new EditQuestionForm(_workingFile.QuestionList);
            Hide();
            form.ShowDialog();
            Show();
            Reload();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //f(QuestionsGridView.SelectedCells[0].RowIndex != 0)
            //{
                EditQuestionForm form = new EditQuestionForm(_workingFile.QuestionList, QuestionsGridView.SelectedCells[0].RowIndex);
                Hide();
                form.ShowDialog();
                Show();
            //}
            Reload();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _workingFile.QuestionList.RemoveAt(QuestionsGridView.SelectedCells[0].RowIndex);
            Reload();
        }

        private void Reload()
        {
            QuestionsGridView.DataSource = null;
            QuestionsGridView.DataSource = _workingFile.QuestionList;
            QuestionsGridView.Update();
            QuestionsGridView.Refresh();
        }

        private void MainEditWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _workingFile.Save();
        }
    }
}
