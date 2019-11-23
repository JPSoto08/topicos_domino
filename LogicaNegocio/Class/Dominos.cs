using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domino.LogicaNegocio.Class
{
    public class Dominos
    {
         private string[] _tiles = {"0,1","0,2","0,3","0,4","0,5","0,6",
                                  "1,2","1,3","1,4","1,5","1,6",
                                  "2,3","2,4","2,5","2,6",
                                  "3,4","3,5","3,6",
                                  "4,5","4,6",
                                  "5,6",
                                  "0,0","1,1","2,2", "3,3", "4,4","5,5","6,6"};
          public List<Domino> AllDominos { get; set; }       
          //public void Shuffle(){} //radomize the dominos

          public Dominos()
          {
              AllDominos = new List<Domino>();

              for (int i = 0; i < _tiles.Length; i++)
              {
                  string[] word = _tiles[i].Split(',');
                  Domino d = new Domino(_tiles[i], int.Parse(word[0]), int.Parse(word[1]), i);
                  AllDominos.Add(d);  
              }
              Shuffle();//randomize the domino list
          }

        public void Shuffle()
        {
            Random r = new Random();

            int n = 7;
            while (n-- > 1)
            {
                int k = r.Next(n + 1);
                Swap(k, n);
            }
        }

        // swap the domino in index 1 with the domino in index 2
        private void Swap(int i1, int i2)
        {
            Domino temp = this.AllDominos[i1];
            this[i1] = this.AllDominos[i2];
            this[i2] = temp;
        }

        public static Domino InitializePlayers(Player player1,Player player2, List<Domino> ListDominos)
        {
            return AllDominos[0];
        }
    }
}