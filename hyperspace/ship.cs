class Ship(){
    def __init__(self, category, name, mass, space, weapon, cost):
        self.category = category # string "category"
        self.name = name # string "name"
        self.mass = mass # integer mass
        self.space = [space, space] # 2x1 array of integers [space left, total space]
        self.weapon = [weapon, weapon] # 2x1 array of integers [weapon slots left, total weapon slots]
        self.engine = 1 # boolean does it have space for an engine?
        self.outfits = [] # list of objects [outfit 1, outfit 2, ..., outfit n]
        self.cost = cost # integer cost
}



allships = []

scouter = Ship("Scouter","Scouter",25,50,1,50000)
allships.append(scouter)