public class Faction{
    public Faction(string inpname, int inpreputation, List<Ship> inpships, List<Outfit> inpoutfits){
        string name = inpname;
        int reputation = inpreputation;
        List<Ship> ships = inpships;
        List<Outfit> outfits = inpoutfits;
    }
}



public void defineFactions(){
    public List<Faction> allfactions = new List<Faction>();
    allfactions.Add("Space Corp",80,{
        Ship("Scouter",25,50,1,50000)
    },{
       Engine("Light Engine",10,2000,5)
    }
}
