using System.Collections.Generic;

namespace HyperSpace{
    public class Faction{
        public string name {get;}
        public int reputation {get;set;}
        public List<Ship> ships {get;}
        public List<Outfit> outfits {get;}

        public Faction(string inpname, int inpreputation, List<Ship> inpships, List<Outfit> inpoutfits){
            name = inpname;
            reputation = inpreputation;
            ships = inpships;
            outfits = inpoutfits;
        }
    }



    public class Coordinate{
        public int x {get;}
        public int y {get;}
        public int z {get;}

        public Coordinate(int tox, int toy, int toz){
            x = tox;
            y = toy;
            z = toz;
        }
    }



    public class System{
        public string name {get;}
        public Coordinate coordinates {get;}
        public Faction faction {get;}
        public List<Landing> landings {get;}

        public System(string inpname, Coordinate inpcoordinates, Faction inpfaction, List<Landing> inplandings){
            name = inpname;
            coordinates = inpcoordinates;
            faction = inpfaction;
            landings = inplandings;
        }
    }



    public class Landing{
        public string name {get;}
        public bool shipyard {get;}
        public bool outfitter {get;}

        public Landing(string inpname, bool inpshipyard, bool inpoutfitter){
            name = inpname;
            shipyard = inpshipyard;
            outfitter = inpoutfitter;
        }
    }
}