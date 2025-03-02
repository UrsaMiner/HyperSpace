public class Ship{
    public Ship(int inpspace) => public int[2] space = [inpspace, inpspace]; //space left, total space
    public Ship(int inpweapon) => public int[2] weapon = [inpweapon, inpweapon]; //slots left, total slots
    public Ship(int inpcost) => public int cost = inpcost;
    public Ship(string inpcategory) => public string name = public string category = inpcategory;
    public Ship(int inpmass) => public int mass = inpmass;
    public int engine = 1; //1 is has space, 0 is doesnt
    public List<Outfit> outfits = [];
}


/*
allships = []

scouter = Ship("Scouter","Scouter",25,50,1,50000)
allships.append(scouter)
*/
