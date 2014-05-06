using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    class GameController
    {
        public GameController()
        {
            myTheseus = new Theseus(this);
        }

        Level currentLevel; //requires instance?
        Theseus myTheseus;
        Minotaur myMinotaur;
        List<Direction> moveList = new List<Direction>();
        float timer;

        internal Theseus MyTheseus
        {
            get { return myTheseus; }
            set { myTheseus = value; }
        }

        internal Minotaur MyMinotaur
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
