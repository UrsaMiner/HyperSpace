using System.Collections.Generic;

namespace HyperSpace{
    public class Faction(string name, int reputation, List<Ship> ships, List<Outfit> outfits){
        public string name { get; } = name;
        public int reputation { get; set; } = reputation;
        public List<Ship> ships { get; } = ships;
        public List<Outfit> outfits { get; } = outfits;
    }



    public class System(string name, Coordinate coordinates, Faction faction, List<Landing> landings){
        public string name { get; } = name;
        public Coordinate coordinates { get; } = coordinates;
        public Faction faction { get; } = faction;
        public List<Landing> landings { get; } = landings;
    }



    public class Landing(string name, bool shipyard, bool outfitter){
        public string name { get; } = name;
        public bool shipyard { get; } = shipyard;
        public bool outfitter { get; } = outfitter;
    }
}