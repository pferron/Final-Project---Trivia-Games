using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Games
{
    public class UserCurrentPoints: User
    {
        private int NumberOfCorrectAnswers;

        public UserCurrentPoints(string uID, string uFN, string uLN, int noca)
            : base(uID, uFN, uLN)
        {
            NumberOfCorrectAnswers = noca;
        }

        public int NumberOfCorrectAnswers1
        {
            get { return NumberOfCorrectAnswers; }
            set { NumberOfCorrectAnswers = value; }
        }
    }
}
