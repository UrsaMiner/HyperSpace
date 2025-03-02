class Landing(){
    required string name;
    required bool shipyard;
    required bool outfitter;

    static object[] findStar(){
        foreach(object currstar in allstars){
            if (self in currstar.landings){
                return currstar;
            }
        }
    }
}


/*
alllandings = []

earth = Landing("Earth", 0, 1, 1)
alllandings.append(earth)

mars = Landing("Mars", 0, 0, 1)
alllandings.append(mars)
*/