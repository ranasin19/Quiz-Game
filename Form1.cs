using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qgame
{
    public partial class Form1 : Form
    {
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
        private void CheckAnswersEvents(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {


                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "!اللعبة انتهت" + Environment.NewLine +
                    "لقد أجبت على "  + score +  " اسئلة." + Environment.NewLine +
                   "OK للعب مجددا اضغط"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }
        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.eygpt;

                    lblQuestion.Text = "ماهي عاصمة مصر؟";

                    button1.Text = "بيروت";
                    button2.Text = "القاهرة";
                    button3.Text = "الرياض";
                    button4.Text = "الكويت";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.nhrt;

                    lblQuestion.Text = "ماهو اطول نهر بالعالم؟";

                    button1.Text = "نهر النيل";
                    button2.Text = "نهر الارن";
                    button3.Text = "نهر دجلة";
                    button4.Text = "نهر المسيسي";

                    correctAnswer = 1;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "ما اسم هذه اللعبة؟";

                    button1.Text = "Call of Duty";
                    button2.Text = "Battlefield";
                    button3.Text = "Fortnite";
                    button4.Text = "CS - GO";

                    correctAnswer = 3;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.abs;

                    lblQuestion.Text = "ماهو عدد العضلات في جسم الانسان؟";

                    button1.Text = "عضلة";
                    button2.Text = "1000";
                    button3.Text = "111";
                    button4.Text = "620";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.space;

                    lblQuestion.Text = "من هو اول رائد فضاء سعودي؟";

                    button1.Text = "الأمير سلطان بس سلمان";
                    button2.Text = "الأمير خالد بن فيصل";
                    button3.Text = "الوليد بن طلال";
                    button4.Text = "أحمد الصانع";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.coding;

                    lblQuestion.Text = "اي من التالي تعتبر من لغات البرمجة؟";

                    button1.Text = "C#";
                    button2.Text = "paython";
                    button3.Text = "java";
                    button4.Text = "جميع ما سبق";

                    correctAnswer = 4;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.sea;

                    lblQuestion.Text = "ماهو اخطر الحيوانات البحرية؟";

                    button1.Text = "الاخطبوط";
                    button2.Text = "القرش";
                    button3.Text = "الحوت الازرق";
                    button4.Text = "حصان البحر";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.aus;

                    lblQuestion.Text = "ماهي عاصمة استراليا؟";

                    button1.Text = "Birmingham";
                    button2.Text = "Brighton";
                    button3.Text = "Liverpool";
                    button4.Text = "Canberra";

                    correctAnswer = 4;

                    break;
            }
            }
    }
}
