using System;
using System.Collections.Generic;
using EfSamuariDomain.Entities;
using EfSamuariDomain.Entities.Moves;

namespace SamuraiConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for (int l = 0; l < 10; l++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Samurai"+ l);
                
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.ResetColor();
                var samurai = new Samurai();
                samurai.Stats.GainXp(600000);
                Console.WriteLine("samuria stats");
                Console.WriteLine($"HP: {samurai.Stats.Hp}  " +
                                  $"Dex: {samurai.Stats.Dexterity}  " +
                                  $"Int: {samurai.Stats.Intelligens}  " +
                                  $"Str: {samurai.Stats.Strenght}  " +
                                  $"Vit: {samurai.Stats.Vitality}  " +
                                  $"");
            

            var kicks = new List<Kick>();
            var dodges = new List<Dodge>();
            var punches = new List<Punch>();
            var blocks = new List<Block>();
           


                for (int i = 0; i < 100; i++)
                {
                    var kick = samurai.CombatMove.OffensiveCombatMove.Kick();
                    var dodge = samurai.CombatMove.DefensiveCombatMove.Dodge();
                    var punch = samurai.CombatMove.OffensiveCombatMove.Punch();
                    var block = samurai.CombatMove.DefensiveCombatMove.Block();

                    blocks.Add(block);
                    punches.Add(punch);
                    kicks.Add(kick);
                    dodges.Add(dodge);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Kicks------------------------------------------");
                var j = 0;
                foreach (var kick in kicks)
                {
                    j++;
                    Console.Write(kick.Damage + ", ");
                    j = LineBreaker(j);

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Dodges---------------------------------------");
                var k = 0;
                foreach (var dodge in dodges)
                {
                    k++;
                    Console.Write(dodge.DamageReduction + ", ");
                    k = LineBreaker(k);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Punches------------------------------------");
                var h = 0;
                foreach (var punch in punches)
                {
                    h++;
                    Console.Write(punch.Damage + ", ");
                    h = LineBreaker(h);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Blocks-------------------------------------");
                var g = 0;
                foreach (var block in blocks)
                {
                    g++;
                    Console.Write(block.DamageReduction + ", ");
                    g = LineBreaker(g);
                }
               
            }
            Console.ReadKey();
        }

        private static int LineBreaker(int loopCounter)
        {
            if (loopCounter == 30)
            {
                loopCounter = 0;
                Console.WriteLine();
            }
            return loopCounter;
        }
    }
}