namespace TestsApp
{
    partial class MainTestWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer5 = new System.Windows.Forms.RadioButton();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.EndItPLease = new System.Windows.Forms.Button();
            this.QuestionIndexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(12, 99);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(85, 17);
            this.Answer1.TabIndex = 0;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(12, 122);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(85, 17);
            this.Answer2.TabIndex = 1;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton2";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(12, 145);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(85, 17);
            this.Answer3.TabIndex = 2;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton3";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(12, 168);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(85, 17);
            this.Answer4.TabIndex = 3;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "radioButton4";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Answer5
            // 
            this.Answer5.AutoSize = true;
            this.Answer5.Location = new System.Drawing.Point(12, 191);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(85, 17);
            this.Answer5.TabIndex = 4;
            this.Answer5.TabStop = true;
            this.Answer5.Text = "radioButton5";
            this.Answer5.UseVisualStyleBackColor = true;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(482, 81);
            this.QuestionBox.TabIndex = 5;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(135, 224);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(358, 23);
            this.NextQuestionButton.TabIndex = 7;
            this.NextQuestionButton.Text = "Вперед";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // EndItPLease
            // 
            this.EndItPLease.Location = new System.Drawing.Point(12, 224);
            this.EndItPLease.Name = "EndItPLease";
            this.EndItPLease.Size = new System.Drawing.Size(117, 23);
            this.EndItPLease.TabIndex = 8;
            this.EndItPLease.Text = "Завершить";
            this.EndItPLease.UseVisualStyleBackColor = true;
            this.EndItPLease.Click += new System.EventHandler(this.EndItButton_Click);
            // 
            // QuestionIndexLabel
            // 
            this.QuestionIndexLabel.AutoSize = true;
            this.QuestionIndexLabel.Location = new System.Drawing.Point(458, 101);
            this.QuestionIndexLabel.Name = "QuestionIndexLabel";
            this.QuestionIndexLabel.Size = new System.Drawing.Size(35, 13);
            this.QuestionIndexLabel.TabIndex = 9;
            this.QuestionIndexLabel.Text = "label1";
            // 
            // MainTestWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 257);
            this.Controls.Add(this.QuestionIndexLabel);
            this.Controls.Add(this.EndItPLease);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Name = "MainTestWindows";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.MainTestWindows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer5;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button EndItPLease;
        private System.Windows.Forms.Label QuestionIndexLabel;
    }
}