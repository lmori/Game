using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Theseus_vs_Minotaur_library
{
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

        private bool[][] verticalWallArray;
        [XmlElement(ElementName = "Vertical Wall Array")]

        private bool[][] horizontalWallArray;
        [XmlElement(ElementName = "Horizontal Wall Array")]
        
        // Level [X, Y] rows and columns
        private int[] gridSize;
        [XmlElement(ElementName = "Grid Size")]

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
                    int theseusXPosition, int theseusYPosition, bool[][] verticalWallArray, bool[][] horizontalWallArray, int[] gridSize)
        {
            FileName = fileName;
            LevelName = levelName;
            CreatorName = creatorName;
            MinotaurXPosition = minotaurXPosition;
            MinotaurYPosition = minotaurYPosition;
            TheseusXPosition = theseusXPosition;
            TheseusYPosition = theseusYPosition;
            VerticalWallArray = verticalWallArray;
            HorizontalWallArray = horizontalWallArray;
            GridSize = gridSize;
        }

        //renamed the method from "CanMove" to "IsWall". Changed the parameters it takes
        //from "oldXPosition.." to column and "oldYPosition" to "row"
        //Method takes a column and a row and a direction. It returns a boolean of whether a wall is in that direction
        //suggested usage - if IsWall(column, row, direction) == false then move else dont 
        public bool IsWall(int column, int row, Direction direction)
        {
            int innerArray, innerArrayIndex;
            bool[][] outerArray;
            bool result = false;


            switch (direction)
            {
                case Direction.Right:
                    outerArray = verticalWallArray;
                    innerArray = row - 1;
                    innerArrayIndex = column;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Left:
                    outerArray = verticalWallArray;
                    innerArray = row - 1;
                    innerArrayIndex = column - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Up:
                    outerArray = horizontalWallArray;
                    innerArray = row - 1;
                    innerArrayIndex = column - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.Down:
                    outerArray = horizontalWallArray;
                    innerArray = row;
                    innerArrayIndex = column - 1;
                    result = outerArray[innerArray][innerArrayIndex];
                    break;
                case Direction.NoChange:
                    result = false;
                    break;
            }
            return result;
        }
    
    }
}
