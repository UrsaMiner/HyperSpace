namespace HyperSpace{
    public class Ship{
        public string category {get;}
        public string name {get;set;}
        public uint mass {get;}
        public uint[] space = [0,0];
        public uint[] weapon = [0,0];
        public uint cost {get;}
        public int engine = 1; // 1 -> has engine slot, 0 -> has no engine slot
        public List<Outfit> outfits = new();

        public Ship(string inpcategory, uint inpmass, uint inpspace, uint inpweapon, uint inpcost){
            name = category = inpcategory;
            mass = inpmass;
            space = [inpspace, inpspace]; //space left, total space
            weapon = [inpweapon, inpweapon]; //slots left, total slots
            cost = inpcost;
        }
    }



    public class Outfit{
        public uint category {get;}
        public string name {get;}
        public uint space {get;}
        public uint cost {get;}

        public Outfit(uint inpcategory, string inpname, uint inpspace, uint inpcost){
            category = inpcategory; //(0-2, 0 is default, 1 is weapon, 2 is engine)
            name = inpname;
            space = inpspace;
            cost = inpcost;
        }
    }



    public class Engine : Outfit{
        public uint thrust {get;}
        public Engine(string inpname, uint inpspace, uint inpcost, uint inpthrust) :
        base(2, inpname, inpspace, inpcost){
            thrust = inpthrust;
        }
    }



    public class Weapon : Outfit{
        public uint power {get;}

        public Weapon(string inpname, uint inpspace, uint inpcost, uint inppower) :
        base(1, inpname, inpspace, inpcost){
            power = inppower;
        }
    }
}