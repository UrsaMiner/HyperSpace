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

        public Ship(string category, uint mass, uint space, uint weapon, uint cost){
            this.name = this.category = category;
            this.mass = mass;
            this.space = [space, space]; //space left, total space
            this.weapon = [weapon, weapon]; //slots left, total slots
            this.cost = cost;
        }
    }



    public class Outfit{
        public uint category {get;}
        public string name {get;}
        public uint space {get;}
        public uint cost {get;}

        public Outfit(uint category, string name, uint space, uint cost){
            this.category = category; //(0-2, 0 is default, 1 is weapon, 2 is engine)
            this.name = name;
            this.space = space;
            this.cost = cost;
        }
    }



    public class Engine : Outfit{
        public uint thrust {get;}
        public Engine(string name, uint space, uint cost, uint thrust) :
        base(2, name, space, cost){
            this.thrust = thrust;
        }
    }



    public class Weapon : Outfit{
        public uint power {get;}

        public Weapon(string name, uint space, uint cost, uint power) :
        base(1, name, space, cost){
            this.power = power;
        }
    }
}