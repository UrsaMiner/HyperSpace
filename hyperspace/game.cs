using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

/*
This is where new things are added for now
May change this to a file system later, to make adding new content easier
*/

namespace HyperSpace{
    public class Game{
        static public List<Faction> allfactions = new();
        static public List<System> allsystems = new();
        public Player player;
        public Game(){
            Console.WriteLine("Starting up...");
            defineFactions();
            defineSystems();
            player = new();
            Console.WriteLine("Startup Complete, Welcome to HyperSpace!");
        }
        public void run(){
            while(true)
                player.doAction();
        }
        private void defineFactions(){

            /* 
            Template:
            allfactions.Add(Faction("Faction Name",starting_reputation,
            new List<Ship> {
                new Ship("Ship 1 Name",mass,space,weapons,cost),
                new Ship("Ship 2 Name",mass,space,weapons,cost)
            },
            new List<Outfit> {
                new OutfitSubclass("Outfit 1 Name",size,cost,subclass-specific-stats),
                new OutfitSubclass("Outfit 2 Name",size,cost,subclass-specific-stats)
            }));

            Current Outfit Subclasses:
            Engine - Thrust
            Weapon - Power
            */

            allfactions.Add(new("Space Corp",80,
            new List<Ship> {
                new Ship("Scouter",25,50,1,50000)
            },new List<Outfit> {
                new Engine("Light Engine",10,2000,5)
            }));

        }
        private void defineSystems(){

            /* 
            Template:
            allsystems.Add(System("System Name",new Coordinate(x,y,z),
            new List<Landing> {
                new Landing("Landing 1 Name",has-shipyard,has-outfitter),
                new Landing("Landing 2 Name",has-shipyard,has-outfitter)
            }));

            xyz are relative to Sol
            */

            allsystems.Add(new System("Sol",new Coordinate(0,0,0),allfactions[0],
            new List<Landing> {
                new Landing("Earth",true,true),
                new Landing("Mars",false,true)
            }));

        }
    }



    public class Pronoun(string active, string passive, string activepossessive, string passivepossessive, string reflective, string abbreviated){
        public string active = active;
        public string passive = passive;
        public string activepossessive = activepossessive;
        public string passivepossessive = passivepossessive;
        public string reflective = reflective;
        public string abbreviated = abbreviated;
    }



    public class Coordinate(int x, int y, int z){
        public int x { get; } = x;
        public int y { get; } = y;
        public int z { get; } = z;
    }
}