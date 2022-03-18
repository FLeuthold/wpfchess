using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach
{
    public abstract class Piece : BaseViewModel
    {

        public Piece(bool isblack, string name)
        {
            this.isblack = isblack;
            if (isblack)
            {
                ImagePath = $"/images/{name}Black.jpg";
            }
            else
            {
                ImagePath = $"/images/{name}.jpg";
            }
        }

        private string? imagePath;

        public string ImagePath 
        {
            set
            { 
                OnPropertyChanged("ImagePath");
                imagePath = value;
            }
            get
            {
                Console.WriteLine(imagePath);
                return imagePath;
            } 
        }


        public readonly bool isblack;
        abstract public bool IsPatternValid(Tile start, Tile end, Tile[] tiles);
    }
}
