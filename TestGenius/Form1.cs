using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestGenius
{
    public partial class Form1 : Form
    {
        string[] questions = {"2 + 2 * 2", 
                        "Сколько распилов нужно, чтобы разделить бревно на 10 частей?", 
                        "На 2-х руках 10 пальцев, сколько пальцев на 5 руках?",
                        "Уколы делают каждые полчаса, через сколько минут сделают 3 укола?",
                        "5 свечей горело, две погасло.Сколько свечей осталось?"};
        int[] answers = { 6, 9, 25, 60, 2 };
        string[] results = { "идиот", "дибил", "дурак", "норма", "талант", "гений" };
        int rightAnswer = 0;
        //номер текущего вопроса
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            labelTextQuestion.Text = questions[index];
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int answer = Convert.ToInt32(textBoxAnswerQuestion.Text);
                if (answer == answers[index])
                    {
                        MessageBox.Show("Верно!");
                        rightAnswer++;
                    }
                else
                    MessageBox.Show("Не верно");
                if (index < questions.Length - 1)
                    labelTextQuestion.Text = questions[++index];
                else
                    {
                        MessageBox.Show(results[rightAnswer]);
                    }
            }
            catch
            {
                MessageBox.Show("Введите число!");
            }
        }
    }
}
