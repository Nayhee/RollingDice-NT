using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string RandomTaunt {get; set;}

        public List<string> Taunts = new List<string>()
        {
            "I bet you brush your teeth with your socks on!",
            "You can't handle the truth!",
            "Who you calling a cootie queen, you lint licker!"
        };
        
        public CreativeSmackTalkingPlayer()
        {
            int Ran = new Random().Next(Taunts.Count);
            RandomTaunt = Taunts[Ran];
        }

        public override void Play(Player other)
        {
            Console.WriteLine(RandomTaunt);
            
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }


    }
}