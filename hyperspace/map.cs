public class System(){
    public System(string inpname, int[3] inpcoordinates, Faction inpfaction, List<Landing> inplandings){
        string name = inpname;
        int[3] coordinates = inpcoordinates;
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



public defineSystems(){
    public List<System> allsystems = new List<System>();
    allsystems.Add(System("Sol",[0,0,0],allfactions[0],{
        Landing("Earth",1,1),
        Landing("Mars",0,1)
    }));
}
