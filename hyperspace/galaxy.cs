using System.Collections.Generic;

namespace HyperSpace{
    public class Faction{
        public string name {get;}
        public int reputation {get;set;}
        public List<Ship> ships {get;}
        public List<Outfit> outfits {get;}

        public Faction(string name, int reputation, List<Ship> ships, List<Outfit> outfits){
            this.name = name;
            this.reputation = reputation;
            this.ships = ships;
            this.outfits = outfits;
        }
    }



    public class System{
        public string name {get;}
        public Coordinate coordinates {get;}
        public Faction faction {get;}
        public List<Landing> landings {get;}

        public System(string name, Coordinate coordinates, Faction faction, List<Landing> landings){
            this.name = name;
            this.coordinates = coordinates;
            this.faction = faction;
            this.landings = landings;
        }
    }



    public class Landing{
        public string name {get;}
        public bool shipyard {get;}
        public bool outfitter {get;}

        public Landing(string name, bool shipyard, bool outfitter){
            this.name = name;
            this.shipyard = shipyard;
            this.outfitter = outfitter;
        }
    }
}