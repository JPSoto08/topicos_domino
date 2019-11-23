using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domino.LogicaNegocio.Class
{
    public class Domino
    {
        public string Name { get; set; } // "0,1", "0,2", etc.
        public int Head { get; set; } //each domino has 2 side, i called it head and tail
        public int Tail { get; set; }
        public int Weight { get; set; } //a 0-27, e.g: a "6,6" domino would have the highest predifined weight of 27
        public bool IsDouble { get; set; }  //whether the tile is double or not

        public Domino(string name, int head, int tail, int weight)
        {
            Name = name;
            Head = head;
            Tail = tail;
            Weight = weight;
            IsDouble = (head == tail ? true : false);
        }
    }
}