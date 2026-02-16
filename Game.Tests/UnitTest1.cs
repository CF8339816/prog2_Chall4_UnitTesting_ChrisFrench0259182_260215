using Microsoft.VisualStudio.TestTools.UnitTesting;
using prog2_Chall4_UnitTesting_ChrisFrench0259182_260215;
using System;

namespace Game.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TakeDamage_ReducesHealth()
        {
            Player player = new Player(100, 0, 0);// sets starting health
            //Console.WriteLine($"Player's Starting health is {player.CurrentHealth}");     


            player.TakeDamage(25);//apply damage to player
           // Console.WriteLine($"Player takes 25 points of damage");

            Assert.AreEqual(75, player.CurrentHealth);// checks  to verify the current value  refflects the  damage applied
          //  Console.WriteLine($"player's current health is {player.CurrentHealth}");
           // Console.ReadKey(true);
        }
      







    }
}
