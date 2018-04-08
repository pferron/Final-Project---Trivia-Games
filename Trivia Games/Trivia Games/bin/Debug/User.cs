using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trivia_Games
{
    public class User
    {
        private string userID, userFirstName, userLastName, picUser;

        private int numberOfCorrectAnswers, numberOfQuestions;

        public User()
        {}

        public User(string uID, string uFN, string uLN)
        {
            userID = uID;
            userFirstName = uFN;
            userLastName = uLN;
        }

        public User(string uID, string uFN, string uLN, string picName)
        {
            userID = uID;
            userFirstName = uFN;
            userLastName = uLN;
            picUser = picName;
        }

        public int NumberOfQuestions
        {
            get { return numberOfQuestions; }
            set { numberOfQuestions = value; }
        }

        public int CorrectAnswersNumber
        {
            get { return numberOfCorrectAnswers; }
            set { numberOfCorrectAnswers = value; }
        }

        public string PicUser
        {
            get { return picUser; }
            set { picUser = value; }
        }

        public string UserLastName
        {
            get { return userLastName; }
            set { userLastName = value; }
        }

        public string UserFirstName
        {
            get { return userFirstName; }
            set { userFirstName = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

    }
}
