class Outfit(){
    def __init__(self, category, name, space, cost):
        self.category = category # integer category (0-2, 0 is default, 1 is weapon, 2 is engine)
        self.name = name # string "name"
        self.space = space # integer space
        self.cost = cost # integer cost
}



class Engine(Outfit){
    def __init__(self, name, space, cost):
        self.name = name
        self.space = space
        self.cost = cost
        super().__init__(2,self.name,self.space,self.cost)
}



class Weapon(Outfit){
    def __init__(self, name, space, cost):
        self.name = name
        self.space = space
        self.cost = cost
        super().__init__(1,self.name,self.space,self.cost)
}



class General(Outfit){
    def __init__(self, name, space, cost):
        self.name = name
        self.space = space
        self.cost = cost
        super().__init__(0,self.name,self.space,self.cost)
}



alloutfits = []

engine_light = Engine("Light Engine",10,1000)
alloutfits.append(engine_light)