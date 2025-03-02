public class Player{
    public Player(){
        object ship = null;
        ulong money = 100000L;
        Star currstar = allstars[0];
        Landing currlanding = currstar.landings[0];
        string name = input("Name: ");
    }
        void doAction(){
            string action = input("\nWhat would you like to do?\n").ToLower();
            switch (action){
                case "sell ship":
                    sellShip();
                case "sell outfit":
                    sellOutfit();
                case "buy ship":
                    buyShip();
                case "buy outfit":
                    buyOutfit();
                case "rename ship":
                    renameShip();
                case "land":
                    land();
                case "depart":
                    depart();
                case "jump":
                    jump();
                case "help":
                    help();
                case "reputation":
                    reputation();
                case "balance":
                    balance();
                case "ship":
                    viewShip();
                case "services":
                    services();
            }
        }
    void sellShip(){
        if (ship != null){
            money += ship.cost * 0.5;
            Console.WriteLine("You have sold your " + ship.category + ", " + ship.name + ".");
            ship = null;
        }
    }
    string grammarN(string name){
        if (name[0] in ["a","e","i","o","u"])
            return string "n";
        else
            return string "";
        }
    }
    void sellOutfit(){
        outfitname = input("Which outfit do you want to sell?\n").ToLower();
        success = 0;
        foreach (Outfit curroutfit in ship.outfits){
            if (curroutfit.name.ToLower() == outfitname){
                object outfittosell = curroutfit;
                success = 1;
            }
        }
        if (success){
            if (outfittosell in ship.outfits){
                money += outfittosell.cost * 0.5;
                Console.WriteLine("You have sold a" + grammarN(outfittosell.name) + " " + outfittosell.name + ".");
                ship.outfits.delete(outfittosell);
                ship.space[0] += outfittosell.space;
                if (outfittosell.category == 1){
                    ship.weapon[0] += 1;
                } else if (outfittosell.category == 2){
                    ship.engine = 1;
                }
            else
                Console.WriteLine("You don't have that outfit installed.");
        }
        else
            Console.WriteLine("That outfit doesn't exist.");
        }
    }

    void buyShip(){
        success = 0
        shipname = input("Which ship do you want to buy?\n").ToLower()
        for i in range(len(allships)):
            if allships[i].name.ToLower() == shipname:
                shiptobuy = allships[i]
                success = 1
        if success:
            if shiptobuy.cost <= money:
                money -= shiptobuy.cost
                ship = shiptobuy
                grammarn = ""
                if shiptobuy.name[0] in ["a","e","i","o","u"]:
                    grammarn = "n"
                Console.WriteLine("You have bought a" + grammarn + " " + shiptobuy.name + ".")
            else:
                Console.WriteLine("You don't have enough money.")
        else:
            Console.WriteLine("That ship doesn't exist.")
    }

    void buyOutfit(){
        outfitname = input("Which outfit do you want to buy?\n").ToLower()
        success = 0
        for i in range(len(alloutfits)):
            if alloutfits[i].name.ToLower() == outfitname:
                outfittobuy = alloutfits[i]
                success = 1
        if success:
            bought = 0
            if outfittobuy.cost <= money:
                if ship != None:
                    if ship.space[0] >= outfittobuy.space:
                        if outfittobuy.category == 1:
                            if ship.weapon[0]:
                                money -= outfittobuy.cost
                                ship.outfits.append(outfittobuy)
                                ship.space[0] -= outfittobuy.space
                                ship.weapon[0] -= 1
                                bought = 1
                            else:
                                Console.WriteLine("You don't have a free weapon slot.")
                        else if outfittobuy.category == 2:
                            if ship.engine:
                                money -= outfittobuy.cost
                                ship.outfits.append(outfittobuy)
                                ship.space[0] -= outfittobuy.space
                                ship.engine = 0
                                bought = 1
                            else:
                                Console.WriteLine("You already have an engine installed.")
                        else if outfittobuy.category == 0:
                            money -= outfittobuy.cost
                            ship.outfits.append(outfittobuy)
                            ship.space[0] -= outfittobuy.space
                            bought = 1
                    else:
                        Console.WriteLine("You don't have enough space.")
                else:
                    Console.WriteLine("You don't have a ship.")
            else:
                Console.WriteLine("You don't have enough money.")
        else:
            Console.WriteLine("That outfit doesn't exist.")
        if bought:
            grammarn = ""
            if outfittobuy.name[0] in ["a","e","i","o","u"]:
                grammarn = "n"
            Console.WriteLine("You have bought a" + grammarn + " " + outfittobuy.name + ".")
    }

    void renameShip(){
        if (ship != null)
            ship.name = input("New Ship Name: ");
        else
            Console.WriteLine("You don't have a ship to rename.");
    }

    void land(){
        if (currlanding == null){
            int success = 0
            landingname = input("Which landing do you want to land on?\n").ToLower()
            foreach(cyclestar in currstar.landings){
                if (cyclestar.name.ToLower() == landingname){
                    toland = cyclestar
                    success = 1
                }
            }
            if (success){
                currlanding = toland;
                Console.WriteLine("Landing on " + location.name + ".");
            } else
                Console.WriteLine("You can't land there right now.");
        } else
            Console.WriteLine("You can't do that right now.");
    }

    void depart(){
        if (currlanding != null){
            Console.WriteLine("You have departed from " + location.name + ".");
            currlanding = null;
        } else
            Console.WriteLine("You can't do that right now.");
    }

    void jump(){
        if isinstance(location, Star):
            starname = input("Where would you like to jump to?\n").ToLower()
            success = 0
            foreach(Faction cyclefaction in allfactions{
                foreach(Star cyclestar in cyclefaction.stars){
                    if (cyclestar.name.ToLower() == starname){
                        success = 1;
                        destination = cyclestar;
                    }
                }
            }
            if success:
                /*
                distx = jump.coordinates[0] - location.coordinates[0]
                disty = jump.coordinates[1] - location.coordinates[1]
                distz = jump.coordinates[2] - location.coordinates[2]
                dist = (distx + disty + distz) / 3
                */
                currstar = destination;
                Console.WriteLine("You have jumped to " + location.name + ".");
            else:
                Console.WriteLine("You can't jump there right now.");
        else:
            Console.WriteLine("You can't do that right now.");
    }

    void reputation(){
        facname = input("Which faction would you like to view?\n").ToLower()
        success = 0
        foreach (Faction cyclefaction in allfactions){
            if (cyclefaction.name.ToLower() == facname){
                success = 1;
                viewfaction = cyclefaction;
            }
        }
        if (success){
            Console.WriteLine("Your reputation with " + viewfaction.name + " is at " + str(viewfaction.reputation) + "%");
            if (viewfaction.reputation <= 10)
                Console.WriteLine("They are hostile towards you.");
            if (viewfaction.reputation >= 50)
                Console.WriteLine("You can purchase ships from them.");
            if (viewfaction.reputation >= 35)
                Console.WriteLine("You can purchase outfits from them.");
            if (viewfaction.reputation >= 25)
                Console.WriteLine("You can land on their landings.");
        } else
            Console.WriteLine("That faction doesn't exist.");
    }

    void balance(){
        Console.WriteLine("You have " + str(money) + " credits.");
    }

    void viewShip(){
        if (ship == null)
            Console.WriteLine("You don't have a ship.");
        else {
            shipval = ship.cost
            foreach (Outfit cycleoutfit in ship.outfits){
                shipval += cycleoutfit.cost;
                Console.WriteLine("Name: " + ship.name);
                Console.WriteLine("Class: " + ship.category);
                Console.WriteLine("Mass: " + str(ship.mass));
                Console.WriteLine("Outfit Space: " + str(ship.space[0]) + "/" + str(ship.space[1]));
                Console.WriteLine("Weapon Space: " + str(ship.weapon[0]) + "/" + str(ship.weapon[1]));
                Console.WriteLine("Value: " + str(shipval) + " credits");
                Console.WriteLine("OUTFITS:");
            }
            foreach (Outfit cycleoutfit in ship.outfits)
                Console.WriteLine(cycleoutfit.name);
        }
    }


    void services()
        if (currlanding != null){
            int hasnothing = 1;
            if (currlanding.shipyard){
                Console.WriteLine("This Landing has a shipyard.");
                hasnothing = 0;
            }
            if (currlanding.outfitter){
                Console.WriteLine("This Landing has an outfitter.");
                hasnothing = 0;
            }
            if (hasnothing)
                Console.WriteLine("This Landing has no services.");
        else
            Console.WriteLine("You can't do that right now.");
    void help()
        Console.WriteLine("COMMANDS:");
        Console.WriteLine("Buy Ship (Req. Shipyard)\nSell Ship (Req. Shipyard)");
        Console.WriteLine("Buy Outfit (Req. Outfitter) Sell Outfit (Req. Outfitter)");
        Console.WriteLine("Services (Req. On landing)\nDepart (Req. On landing)\nLand (Req. In system)\nJump (Req. In system)");
        Console.WriteLine("Rename Ship\nReputation\nBalance\nShip\nHelp");
    }
}
