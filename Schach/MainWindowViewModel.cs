using Schach.Pieces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Schach
{
    public class MainWindowViewModel : BaseViewModel
    {
        public Tile Save { get; set; }


        

        public ObservableCollection<Tile> Tiles { get; set; }



        public MainWindowViewModel()
        {
            Tiles = new ObservableCollection<Tile>();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Tiles.Add ( new Tile(x, y));
                }

            }

            Tiles[5].Piece = new Dame(false);
            Console.WriteLine("Hallo Velo!");

            this.MoveCommand = new DelegateCommand((source) =>
            {
                var tstart = Save;
                var tend = source as Tile;

                Console.WriteLine("Hallo Velo!");
                
                if(tstart != null)
                {
                    if(tstart.Piece != null)
                    {
                        tend.Piece = tstart.Piece;
                        tstart.Piece = null;
                        //Tiles[tend.X + tend.Y *8 ].Piece = Tiles[tstart.X + tstart.Y * 8].Piece;
                        //Tiles[tstart.X + tstart.Y * 8].Piece = null;
                    }

                }

                Save = tend;
            });

        }

        public DelegateCommand MoveCommand { get; set; }







 
    }
}
