using System;
using Game;
using Player;
using Star;
using Landing;
using Faction;
using Ship;
using Outfit;

namespace HyperSpace{
    class Program{
        static void main(){
            object player = Player();
            while(1){
                doAction();
            }
        }

        static void doAction(){
            string action = input("\nWhat would you like to do?\n").lower();
            switch (action){
                case "sell ship":
                    player.sellShip();
                case "sell outfit":
                    player.sellOutfit();
                case "buy ship":
                    player.buyShip();
                case "buy outfit":
                    player.buyOutfit();
                case "rename ship":
                    player.renameShip();
                case "land":
                    player.land();
                case "depart":
                    player.depart();
                case "jump":
                    player.jump();
                case "help":
                    player.help();
                case "reputation":
                    player.reputation();
                case "balance":
                    player.balance();
                case "ship":
                    player.viewShip();
            }
        }
    }
}