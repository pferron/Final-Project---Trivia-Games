using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Games
{
    class Question_Answers
    {
        private string questionID, question, answer1, answer2, answer3, answer4, correctAnswer;
        private bool alreadyused;

        public Question_Answers(string qID, string q, string a1, string a2, string a3, string a4, string correctA)
        {
            questionID = qID;
            question = q;
            answer1 = a1;
            answer2 = a2;
            answer3 = a3;
            answer4 = a4;
            correctAnswer = correctA;
        }

        public Question_Answers()
        { }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string Answer4
        {
            get { return answer4; }
            set { answer4 = value; }
        }

        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }

        public string Answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }

        public string Answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string QuestionID
        {
            get { return questionID; }
            set { questionID = value; }
        }

        public bool Alreadyused
        {
            get { return alreadyused; }
            set { alreadyused = value; }
        }
        
    }
}
