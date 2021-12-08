using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSite.Models.Quiz
{
    public class QuizState
    {
        public string Answer { get; set; }

        public int powerScore { get; set; }
        public int casualScore { get; set; }
        public int oldschoolScore { get; set; }
        public int brainyScore { get; set; }

        public int questionId { get; set; }

        public string getType()
        {
            int topScore = 0;
            string gamerType = "";

            if (powerScore > topScore)
            {
                topScore = powerScore;
                gamerType = "Power";
            }

            if (casualScore > topScore)
            {
                topScore = casualScore;
                gamerType = "Casual";
            }

            if (oldschoolScore > topScore)
            {
                topScore = oldschoolScore;
                gamerType = "OldSchool";
            }

            if (brainyScore > topScore)
            {
                topScore = brainyScore;
                gamerType = "Brainy";
            }
            return gamerType;
        }
    }
}
