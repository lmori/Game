using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Theseus_vs_Minotaur_library
{
    public class SaveGameList
    {

        private List<SaveGame> savedGames = new List<SaveGame>();

        public List<SaveGame> SavedGames
        {
            get { return savedGames; }
            set { savedGames = value; }
        }

        public SaveGameList()
        {


        }
    }
}
