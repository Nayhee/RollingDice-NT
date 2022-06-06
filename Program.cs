using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";
            
            Player player3 = new Player();
            player3.Name = "Wilma";

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";


            
            Player humanPlayer = new HumanPlayer();
            humanPlayer.Name = "Papi";

            Player oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Bogle";

            Player smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Vince";

            Player creativeSmackTalker = new CreativeSmackTalkingPlayer();
            creativeSmackTalker.Name = "Halliba";

            Player soreLoser = new SoreLoserPlayer();
            soreLoser.Name="John";

            Player upperHalf = new UpperHalfPlayer();
            upperHalf.Name="Holly";

            Player soreUpperHalf = new SoreLoserUpperHalfPlayer();
            soreUpperHalf.Name="Scott";

            // smackTalker.Play(oneHigher);
            // Console.WriteLine("-------------------");
            // oneHigher.Play(soreLoser);
            // Console.WriteLine("-------------------");
            // humanPlayer.Play(smackTalker);
            // Console.WriteLine("-------------------");
            // creativeSmackTalker.Play(oneHigher);
            // Console.WriteLine("-------------------");
            // soreLoser.Play(oneHigher);
            // Console.WriteLine("-------------------");
            // upperHalf.Play(player1);
            // Console.WriteLine("-------------------");
            soreUpperHalf.Play(player1);
            Console.WriteLine("-------------------");

            
            // player2.Play(player1);
            // Console.WriteLine("-------------------");
            // player3.Play(player2);
            // Console.WriteLine("-------------------");
            // player1.Play(large);
            // Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, humanPlayer, oneHigher, smackTalker, creativeSmackTalker
            };

            // PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}