using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Theseus_vs_Minotaur_library
{
    public class ScoreList
    {

        private List<Score> scores = new List<Score>();

        public List<Score> Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        public ScoreList()
        {


        }
    }
}


