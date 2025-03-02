public class Ship{
    public Ship(int inpspace, int inpweapon, int inpcost, string inpcategory, int inpmass){
        protected int[2] space = [inpspace, inpspace]; //space left, total space
        protected int[2] weapon = [inpweapon, inpweapon]; //slots left, total slots
        protected int cost = inpcost;
        protected string name = protected string category = inpcategory;
        protected int mass = inpmass;
        protected int engine = 1; //1 is has space, 0 is doesnt
        protected List<Outfit> outfits = [];
    }
}



public void defineShips(){
    public List<Ship> allships = new List<Ship>();
    allships.Add(Ship("Scouter",25,50,1,50000));
}
