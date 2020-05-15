using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceQuiz
{
    public partial class Form1 : Form
    {
        // quiz name variables
        int correctAnswer;
        int questionNumber = 1; 
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender; // local variable

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                // work out % correct questions
                
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions); // use double for accuracy

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }


            questionNumber++;
            askQuestion(questionNumber);


        }

        private void askQuestion(int qnum) // function takes one argument used to display questions onto screen
        {
            switch (qnum) // switch statement used to display questions
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "What is the colour of the sky?";

                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Red";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "What is the name of the main character from Iron Man?";

                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rodney";
                    button4.Text = "Ted Bundy";

                    correctAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "What is the name of this game?";

                    button1.Text = "Call of Duty";
                    button2.Text = "Battlefield";
                    button3.Text = "Fortnite";
                    button4.Text = "CS-GO";

                    correctAnswer = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "Which Publisher made this game?";

                    button1.Text = "Ubisoft";
                    button2.Text = "EA";
                    button3.Text = "Epic Games";
                    button4.Text = "Square Enix";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.gearsofwar;

                    lblQuestion.Text = "What is the name of this game?";

                    button1.Text = "Gears of War";
                    button2.Text = "Assasins Creed";
                    button3.Text = "Uncharted";
                    button4.Text = "Red Dead Redemption II";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "What is the main characters name from the game above?";

                    button1.Text = "Drake";
                    button2.Text = "Lara Croft";
                    button3.Text = "Master Cheif";
                    button4.Text = "Marcus";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.witcher;

                    lblQuestion.Text = "Who was Geralt looking for in Withcer 3?";

                    button1.Text = "Victoria";
                    button2.Text = "Mr Donut";
                    button3.Text = "Ciri";
                    button4.Text = "Jennifer";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "What is the capital of England?";

                    button1.Text = "Manchester";
                    button2.Text = "Birmingham";
                    button3.Text = "Dublin";
                    button4.Text = "London";

                    correctAnswer = 4;

                    break; // end of switch statement
            }
        }
    }
}
