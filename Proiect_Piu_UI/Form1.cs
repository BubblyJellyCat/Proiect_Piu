using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase;

namespace Proiect_Piu_UI
{
    public partial class Form1 : Form
    {

        int currIntreb = 0;
        int score = 0;
        private Date quizDate;
        private (string Question, string Answer) currentQuestion;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            quizDate = new Date("D:\\code shit\\New folder\\Database.txt");
            currentQuestion = quizDate.GetNextQuestion();
            btnStart.Hide();
            btnCauta.Hide();
            btnAdd.Hide();
            pictureBox1.Hide();
            lblIntrebare.Text = currentQuestion.Question;
            lblIntrebare.Show();
            textBox1.Show();
            btnSubmit.Show();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currIntreb != quizDate.nrIntreb)
            {
                if (textBox1.Text.Trim().ToLower() == currentQuestion.Answer.ToLower())
                {
                    score++;  
                }
                textBox1.Clear();
                currentQuestion = quizDate.GetNextQuestion();
                currIntreb++;
                DisplayQuestion();
            }
            if (currIntreb == quizDate.nrIntreb)
            {
                currentQuestion = quizDate.GetNextQuestion();
            }

        }

        private void DisplayQuestion()
        {
            if (currIntreb < quizDate.nrIntreb)
            {
                lblIntrebare.Text = currentQuestion.Question;
            }
            if (currIntreb == quizDate.nrIntreb)
            {
                lblIntrebare.Text = "Felicitari! Ai raspuns corect la " + score + " intrebari!" ;
                btnSubmit.Hide();
                textBox1.Hide();
                btnMainMenu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIntrebare.Hide();
            btnMainMenu.Hide();
            lblIntrebare2.Hide();
            lblRaspuns2.Hide();
            btnAdaugaIntrebare.Hide();
            txtBoxIntrebare.Hide();
            txtBoxRaspuns.Hide();
            label2.Hide();

            currIntreb = 0;
            score = 0;
            btnStart.Show();
            btnCauta.Show();
            btnAdd.Show();
            pictureBox1.Show();

            btnCautaSubmit.Hide();
            label1.Hide();
            textBox2.Hide();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnCauta.Hide();
            btnAdd.Hide();
            pictureBox1.Hide();

            label1.Show();
            textBox2.Show();
            btnCautaSubmit.Show();
            btnMainMenu.Show();
        }

        private void btnCautaSubmit_Click(object sender, EventArgs e)
        {
            quizDate = new Date("D:\\code shit\\New folder\\Database.txt");
            currentQuestion = quizDate.GetNextQuestion();
            int cautaIndex = Convert.ToInt32(textBox2.Text)-1;
            
            for (int i = 0; i < cautaIndex; i++)
            {
                currentQuestion = quizDate.GetNextQuestion();
            }

            label1.Text = currentQuestion.Question;

            for (int i = 0; i<= quizDate.nrIntreb-cautaIndex; i++)
            {
                currentQuestion = quizDate.GetNextQuestion();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnCauta.Hide();
            btnAdd.Hide();
            pictureBox1.Hide();

            btnMainMenu.Show();
            btnAdaugaIntrebare.Show();
            txtBoxIntrebare.Show();
            txtBoxRaspuns.Show();
            lblIntrebare2.Show();
            lblRaspuns2.Show();
            label2.Show();
        }

        private void btnAdaugaIntrebare_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\code shit\\New folder\\Database.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(txtBoxIntrebare.Text + ";" + txtBoxRaspuns.Text);
                Console.WriteLine("Question added successfully!");
            }

            lblIntrebare.Hide();
            btnMainMenu.Hide();
            lblIntrebare2.Hide();
            lblRaspuns2.Hide();
            btnAdaugaIntrebare.Hide();
            txtBoxIntrebare.Hide();
            txtBoxRaspuns.Hide();
            label2.Hide();

            currIntreb = 0;
            score = 0;
            btnStart.Show();
            btnCauta.Show();
            btnAdd.Show();
            pictureBox1.Show();

            btnCautaSubmit.Hide();
            label1.Hide();
            textBox2.Hide();
        }
    }
}
