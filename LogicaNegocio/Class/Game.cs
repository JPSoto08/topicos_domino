using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domino.LogicaNegocio.Class
{
    public class Game
    {
        //properties
        int ID { get; set; } //game id, assuming each player can play multiple games as once
        Player PlayerTurn { get; set; } //signifies if it is his turn
        Dominos DominoSet { get; set; }
        List<string> Board { get; set; }

        void Move(Player player, Domino domino);

        public Game(Player player1, Player player2)
        {
            ID = 0; //TODO
            DominoSet = new Dominos();  //create a set of dominos
            Board = new List<string>(); //create a new game board that store all the moves 
            Domino curDomino = Dominos.InitializePlayers(player1, player2, DominoSet.AllDominos);
            DominoSet.AllDominos.RemoveRange(0, 14); //remove all dominos that have been assigned to 2 players
                                                     //...and other good stuffs
        }
    }
}