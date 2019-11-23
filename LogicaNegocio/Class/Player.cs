using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domino.LogicaNegocio.Class
{
    public class Player
    {
        //properties
        string ID { get; set; } //player id  
        int Wins { get; set; }
        int Losses { get; set; }
        bool IsMyTurn { get; set; }
        List<Domino> Hand { get; set; } //each player will have a list of domino tiles

        //void ShowHand(); //just display what's in their hands if needed
        //void PlayerStatistic();  //get user's historical wins/losses, number game played, etc.
    }
}