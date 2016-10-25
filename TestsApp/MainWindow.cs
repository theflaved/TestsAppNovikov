using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsApp
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainTestWindows testWindow = new MainTestWindows();
            Hide();
            testWindow.ShowDialog();
            Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            CreateOrEditForm form = new CreateOrEditForm();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
