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



    public class Outfit(uint category, string name, uint space, uint cost){
        public uint category { get; } = category; //(0-2, 0 is default, 1 is weapon, 2 is engine)
        public string name { get; } = name;
        public uint space { get; } = space;
        public uint cost { get; } = cost;
    }



    public class Engine(string name, uint space, uint cost, uint thrust) : Outfit(2, name, space, cost){
        public uint thrust { get; } = thrust;
    }



    public class Weapon(string name, uint space, uint cost, uint power) : Outfit(1, name, space, cost){
        public uint power { get; } = power;
    }
}