public class Faction{
    public Faction(string inpname, int inpreputation, List<Ship> inpships, List<Outfit> inpoutfits){
        string name = inpname;
        int reputation = inpreputation;
        List<Ship> ships = inpships;
        List<Outfit> outfits = inpoutfits;
    }
}



public class Coordinate(){
    public Coordinate(int tox, int toy, int toz){
        int x = tox;
        int y = toy;
        int z = toz;
    }
}



public class System(){
    public System(string inpname, Coordinate inpcoordinates, Faction inpfaction, List<Landing> inplandings){
        string name = inpname;
        Coordinate coordinates = inpcoordinates;
        Faction faction = inpfaction;
        List<Landing> landings = inplandings;
    }
}



public class Landing{
    public Landing(string inpname, int inpshipyard, int inpoutfitter){
        string name = inpname
        int shipyard = inpshipyard
        int outfitter = inpoutfitter
    }
}