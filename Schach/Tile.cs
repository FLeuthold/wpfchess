using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach
{
    public enum Color
    {
        Black,
        White
    }
    public class Tile : BaseViewModel
    {
        private int x;
        private int y;

        private Color color;

        private Piece ? piece;


        public string Path {
            get 
            {
                if(Piece != null)
                {
                    return Piece.ImagePath;
                }
                else
                {
                    return "";
                }
            } 
        }

        public Piece Piece
        {
            set
            {
                piece = value;
                OnPropertyChanged("Piece");
                OnPropertyChanged("Path");
                

                

            }
            get
            {
                
                    return piece;
                
                
            }
        }
        public Color Color 
        {
            set
            {
                color = value;
                OnPropertyChanged("Color");
                
                
            }
            get 
            { 
                return color; 
            } 
        }

        public int Y => y;

        public int X => x;

        public Tile(int x , int y)
        {
            this.x = x;
            this.y = y;

            if ((x + y) % 2 == 0)
            {
                Color = Color.White;
            }
            else
            {
                Color = Color.Black;
            }
             
        }


    }
}
