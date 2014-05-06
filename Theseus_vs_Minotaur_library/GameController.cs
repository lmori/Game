using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    public class GameController
    {
        Level currentLevel; 
        Theseus myTheseus;
        Minotaur myMinotaur;
        List<Direction> moveList = new List<Direction>();
        float timer;

        public GameController()
        {
            myTheseus = new Theseus(this);
            myMinotaur = new Minotaur(this);
        }

        public Theseus MyTheseus
        {
            get { return myTheseus; }
            set { myTheseus = value; }
        }

        public Minotaur MyMinotaur
        {
            get { return myMinotaur; }
            set { myMinotaur = value; }
        }
        
        public float Timer
        {
            get { return timer; }
            set { timer = value; }
        }

        public Level CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }

        public void LogMove(Direction direction)
        {
            this.moveList.Add(direction);
        }
    }

    public enum Direction
    {
        NoChange,
        Right,
        Left,
        Up,
        Down        
    }


}