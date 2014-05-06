using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_vs_Minotaur_library
{
    public class GameController
    {
        private StorageController myStorageController;
        private Level currentLevel;
        private Theseus myTheseus;
        private Minotaur myMinotaur;
        private User myCurrentUser;

       // Level currentLevel = new Level(); //requires instance?
        Theseus myTheseus;
        Minotaur myMinotaur;
        List<Direction> moveList = new List<Direction>();
   

        public void LogMove(Direction direction)
        {
            moveList.Add(direction);
        }
                
        public Level CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
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

        public User MyCurrentUser
        {
            get { return myCurrentUser; }
            set { myCurrentUser = value; }
        }
       
        public float Timer
        {
            get { return timer; }
            set { timer = value; }
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
