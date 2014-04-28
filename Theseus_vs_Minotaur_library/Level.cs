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

            private int theseusXPosition;
            [XmlElement(ElementName = "Theseus X Position")]

            private int minotaurXPosition;
            [XmlElement(ElementName = "Minotaur X Position")]

            private int theseusYPosition;
            [XmlElement(ElementName = "Theseus Y Position")]

            private int minotaurYPosition;
            [XmlElement(ElementName = "Minotaur Y Position")]

            private Array verticalWallArray;
            [XmlElement(ElementName = "Vertical Wall Array")]

            private Array horizontalWallArray;
            [XmlElement(ElementName = "Horizontal Wall Array")]
            
            private Array gridSize;
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

            public Array VerticalWallArray
            {
                get { return verticalWallArray; }
                set { verticalWallArray = value; }
            }

            public Array HorizontalWallArray
            {
                get { return horizontalWallArray; }
                set { horizontalWallArray = value; }
            }
            
            public Array GridSize
            {
                get { return gridSize; }
                set { gridSize = value; }
            }

            public Level() { }

            /*
            public Level(String fileName, String levelName, String creatorName, int minotaurXPosition, int minotaurYPosition,
                        int theseusXPosition, int theseusYPosition, Array verticalWallArray, Array horizontalWallArray, Array gridSize)
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
             */

            public bool CanMove(int oldXPosition, int oldYPosition, int newXPosition, int newYPosition)
            {
                //isOutOfBounds
                return true;
            }
        }



}
