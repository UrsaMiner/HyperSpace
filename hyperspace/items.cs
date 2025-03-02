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