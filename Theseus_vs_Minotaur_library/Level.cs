using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Theseus_vs_Minotaur_library
{

[Serializable]
    public class Level
    {
        private string fileName;
        [XmlElement(ElementName = "File Name")]

        private string levelName;
        [XmlElement(ElementName = "Level Name")]

        private string creatorName;
        [XmlElement(ElementName = "Creator Name")]

        // Initial level starting position
        private int theseusXPosition;
        [XmlElement(ElementName = "Theseus X Position")]

        // Initial level starting position
        private int minotaurXPosition;
        [XmlElement(ElementName = "Minotaur X Position")]

        // Initial level starting position
        private int theseusYPosition;
        [XmlElement(ElementName = "Theseus Y Position")]

        // Initial level starting position
        private int minotaurYPosition;
        [XmlElement(ElementName = "Minotaur Y Position")]

        // Initial level starting position
        private int exitXPosition;      
        [XmlElement(ElementName = "Exit X Position")]

        // Initial level starting position
        private int exitYPosition;
        [XmlElement(ElementName = "Exit Y Position")]

        private bool[][] verticalWallArray;
        [XmlElement(ElementName = "Vertical Wall Array")]

        private bool[][] horizontalWallArray;
        [XmlElement(ElementName = "Horizontal Wall Array")]
        
        // Level [X, Y] rows and columns
        private int[] gridSize;
        [XmlElement(ElementName = "Grid Size")]


        private bool isLevelFinished;


        public bool IsLevelFinished
        {
          get { return isLevelFinished; }
          set { isLevelFinished = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public string LevelName
        {
            get { return levelName; }
            set { levelName = value; }
        }

        public int MinotaurXPosition
        {
            get { return minotaurXPosition; }
            set { minotaurXPosition = value; }
        }

        public int TheseusXPosition
        {
            get { return theseusXPosition; }
            set { theseusXPosition = value; }
        }

        public int MinotaurYPosition
        {
            get { return minotaurYPosition; }
            set { minotaurYPosition = value; }
        }

        public int TheseusYPosition
        {
            get { return theseusYPosition; }
            set { theseusYPosition = value; }
        }
        public int ExitXPosition
        {
            get { return exitXPosition; }
            set { exitXPosition = value; }
        }

        public int ExitYPosition
        {
            get { return exitYPosition; }
            set { exitYPosition = value; }
        }


        public string CreatorName
        {
            get { return creatorName; }
            set { creatorName = value; }
        }

        public bool[][] VerticalWallArray
        {
            get { return verticalWallArray; }
            set { verticalWallArray = value; }
        }

        public bool[][] HorizontalWallArray
        {
            get { return horizontalWallArray; }
            set { horizontalWallArray = value; }
        }

        public int[] GridSize
        {
            get { return gridSize; }
            set { gridSize = value; }
        }

        public Level(String fileName, String levelName, String creatorName, int minotaurXPosition, int minotaurYPosition,
                    int theseusXPosition, int theseusYPosition, int exitXPosition, int exitYPosition,
                    bool[][] verticalWallArray, bool[][] horizontalWallArray, int[] gridSize, bool levelFinished)
        {
            FileName = fileName;
            LevelName = levelName;
            CreatorName = creatorName;
            MinotaurXPosition = minotaurXPosition;
            MinotaurYPosition = minotaurYPosition;
            TheseusXPosition = theseusXPosition;
            TheseusYPosition = theseusYPosition;
            ExitXPosition = exitXPosition;
            ExitYPosition = exitYPosition;
            VerticalWallArray = verticalWallArray;
            HorizontalWallArray = horizontalWallArray;
            GridSize = gridSize;
            isLevelFinished = levelFinished;
        }
        public Level()
        {

        }

       


        //suggested usage - if IsWall(x, y, direction) == false then move else dont 
        public bool IsWall(int x, int y, Direction direction)
        {
            int innerArray, innerArrayIndex;
            bool[][] outerArray;
            bool result = false;
            switch (direction)
            {
                case Direction.Right:
                    outerArray = verticalWallArray;
                    innerArray = y - 1;
                    innerArrayIndex = x;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Left:
                    outerArray = verticalWallArray;
                    innerArray = y - 1;
                    innerArrayIndex = x - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Up:
                    outerArray = horizontalWallArray;
                    innerArray = y - 1;
                    innerArrayIndex = x - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Down:
                    outerArray = horizontalWallArray;
                    innerArray = y;
                    innerArrayIndex = x - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.NoChange:
                    result = false;
                    Console.WriteLine(result);
                    break;
            }
            return result;
        }
    
    }
}
