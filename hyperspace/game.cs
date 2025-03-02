/*
This is where new things are added for now
May change this to a file system later, to make adding new content easier
*/

public class Game{
    public Game(){
        Console.WriteLine("Starting up...");
        public List<Faction> allfactions = new List<Faction>();
        defineFactions();
        public List<System> allsystems = new List<System>();
        defineSystems();
        Player player = Player();
        Console.WriteLine("Startup Complete, Welcome to HyperSpace!")
        while(1)
            player.doAction();
    }
    void defineFactions(){

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

        allfactions.Add(Faction("Space Corp",80,
        new List<Ship> {
            new Ship("Scouter",25,50,1,50000)
        },new List<Outfit> {
            new Engine("Light Engine",10,2000,5)
        }));

    }
    void defineSystems(){

        /* 
        Template:
        allsystems.Add(System("System Name",new Coordinate(x,y,z),
        new List<Landing> {
            new Landing("Landing 1 Name",has-shipyard,has-outfitter),
            new Landing("Landing 2 Name",has-shipyard,has-outfitter)
        }));

        xyz are relative to Sol
        */

        allsystems.Add(System("Sol",new Coordinate(0,0,0),allfactions[0],
        new List<Landing> {
            new Landing("Earth",1,1),
            new Landing("Mars",0,1)
        }));

    }
}