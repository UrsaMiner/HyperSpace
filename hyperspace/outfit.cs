public class Outfit{
    Outfit(int inpcategory, string inpname, int inpspace, int inpcost){
        protected int category = inpcategory; //(0-2, 0 is default, 1 is weapon, 2 is engine)
        protected string name = inpname;
        protected int space = inpspace;
        protected int cost = inpcost;
    }
}



public class Engine : Outfit{
    Engine(string inpname, int inpspace, int inpcost, int inpthrust) :
    base(2, inpname inpspace, inpcost){
        protected int thrust = inpthrust;
    }
}



public class Weapon : Outfit{
    Weapon(string inpname, int inpspace, int inpcost, int inppower) :
    base(1, inpname, inpspace, inpcost){
        protected int power = inppower;
    }
}

public void defineOutfits(){
    public List<Outfit> alloutfits = new List<Outfit>();
    alloutfits.Add(Engine("Light Engine",10,2000,5));
}
