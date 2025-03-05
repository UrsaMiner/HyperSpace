using System;
using System.Runtime.CompilerServices;

namespace HyperSpace{
    public class Player{
        public Ship? ship = null;
        public ulong money = 100000L;
        public System currsystem = Game.allsystems[0];
        public Landing? currlanding = Game.allsystems[0].landings[0];
        public Faction currzone = Game.allfactions[0];
        public string name = "John Doe";

        public void changeName(){
            Console.WriteLine("Name:\n");
            string testname = Console.ReadLine();
            if (testname != null){
                name = testname;
            }
        }
        
        public void doAction(){
            Console.WriteLine("\nWhat would you like to do?");
            string action = Console.ReadLine();
            if (action != null){
                action = action.ToLower();
                switch (action){
                    case "sell ship":
                        sellShip();
                        break;
                    case "sell outfit":
                        sellOutfit();
                        break;
                    case "buy ship":
                        buyShip();
                        break;
                    case "buy outfit":
                        buyOutfit();
                        break;
                    case "rename ship":
                        renameShip();
                        break;
                    case "land":
                        land();
                        break;
                    case "depart":
                        depart();
                        break;
                    case "jump":
                        jump();
                        break;
                    case "reputation":
                        reputation();
                        break;
                    case "balance":
                        balance();
                        break;
                    case "ship":
                        viewShip();
                        break;
                    case "services":
                        services();
                        break;
                    case "rename pilot":
                        changeName();
                        break;
                    case "help":
                    default:
                        help();
                        break;
                }
            }
        }
        
        public void sellShip(){
            if (ship != null){
                money += (ulong)(ship.cost * 0.5);
                Console.WriteLine("You have sold your " + ship.category + ", " + ship.name + ".");
                ship = null;
            }
        }
        
        public string grammarN(string name){
            if("aeiou".Contains(name[0]))
                return "n";
            else
                return "";
        }

        public void sellOutfit(){
            if (ship != null & currlanding != null){
                if (currlanding.outfitter){
                    Console.WriteLine("Which outfit do you want to sell?\n");
                    string outfitname = Console.ReadLine();
                    bool success = false;
                    if (outfitname != null){
                        outfitname = outfitname.ToLower();
                        foreach (Outfit cycleoutfit in ship.outfits){
                            if (!success & cycleoutfit.name.ToLower() == outfitname){
                                Outfit outfittosell = cycleoutfit;
                                success = true;
                                money += (ulong)(outfittosell.cost * 0.5);
                                Console.WriteLine("You have sold a" + grammarN(outfittosell.name) + " " + outfittosell.name + ".");
                                ship.outfits.Remove(outfittosell);
                                ship.space[0] += outfittosell.space;
                                if (outfittosell.category == 1)
                                    ship.weapon[0] += 1;
                                else if (outfittosell.category == 2)
                                    ship.engine = 1;
                            }
                        }
                    }
                    if (!success)
                        Console.WriteLine("You don't have that outfit installed.");
                } else
                    Console.WriteLine("There isn't an outfitter here.");
            } else
                Console.WriteLine("You don't have a ship.");
        }

        public void buyShip(){
            if (currlanding != null & currlanding.shipyard){
                Console.WriteLine("Which ship do you want to buy?\n");
                bool success = false;
                string shipname = Console.ReadLine();
                if (shipname != null){
                    shipname = shipname.ToLower();
                    foreach (Ship cycleship in currzone.ships){
                        if (cycleship.name.ToLower() == shipname){
                            Ship shiptobuy = cycleship;
                            success = true;
                            if (shiptobuy.cost <= money){
                                money -= shiptobuy.cost;
                                ship = shiptobuy;
                                Console.WriteLine("You have bought a" + grammarN(shiptobuy.name) + " " + shiptobuy.name + ".");
                            } else
                                Console.WriteLine("You don't have enough money.");
                        }
                    }
                }
                if (!success)
                    Console.WriteLine("You can't buy that here");
            } else
                Console.WriteLine("You can't do that here");
        }
        public void buyOutfit(){
            if (currlanding != null & currlanding.outfitter){
                Console.WriteLine("Which outfit do you want to buy?\n");
                string outfitname = Console.ReadLine();
                bool success = false;
                if (outfitname != null){
                    outfitname = outfitname.ToLower();
                    foreach (Outfit cycleoutfit in currzone.outfits){
                        if (cycleoutfit.name.ToLower() == outfitname){
                            Outfit outfittobuy = cycleoutfit;
                            success = true;
                            if (outfittobuy.cost <= money){
                                if (ship != null){
                                    if (ship.space[0] >= outfittobuy.space){
                                        if (outfittobuy.category == 1){
                                            if (ship.weapon[0] != 0){
                                                money -= outfittobuy.cost;
                                                ship.outfits.Add(outfittobuy);
                                                ship.space[0] -= outfittobuy.space;
                                                ship.weapon[0] -= 1;
                                                Console.WriteLine("You have bought a" + grammarN(outfittobuy.name) + " " + outfittobuy.name + ".");
                                            } else
                                                Console.WriteLine("You don't have a free weapon slot.");
                                        } else if (outfittobuy.category == 2){
                                            if (ship.engine != 0){
                                                money -= outfittobuy.cost;
                                                ship.outfits.Add(outfittobuy);
                                                ship.space[0] -= outfittobuy.space;
                                                ship.engine = 0;
                                                Console.WriteLine("You have bought a" + grammarN(outfittobuy.name) + " " + outfittobuy.name + ".");
                                            } else
                                                Console.WriteLine("You already have an engine installed.");
                                        } else if (outfittobuy.category == 0){
                                            money -= outfittobuy.cost;
                                            ship.outfits.Add(outfittobuy);
                                            ship.space[0] -= outfittobuy.space;
                                            Console.WriteLine("You have bought a" + grammarN(outfittobuy.name) + " " + outfittobuy.name + ".");
                                            }
                                        } else
                                        Console.WriteLine("You don't have enough space.");
                                } else
                                    Console.WriteLine("You don't have a ship.");
                            } else
                                Console.WriteLine("You don't have enough money.");
                        }
                    }
                }
                if (!success)
                    Console.WriteLine("You can't buy that here.");
            } else
                Console.WriteLine("You can't do that here.");
        }
        public void renameShip(){
            if (ship != null){
                Console.WriteLine("What should her new name be?\n");
                string testname = Console.ReadLine();
                if (testname != null)
                    ship.name = testname;
            } else
                Console.WriteLine("You don't have a ship to rename.");
        }

        public void land(){
            if (currlanding == null){
                bool success = false;
                Console.WriteLine("Which landing do you want to land on?\n");
                string landingname = Console.ReadLine();
                if (landingname != null){
                    landingname = landingname.ToLower();
                    foreach(Landing cyclelanding in currsystem.landings){
                        if (cyclelanding.name.ToLower() == landingname){
                            Landing toland = cyclelanding;
                            success = true;
                            currlanding = toland;
                            Console.WriteLine("Landing on " + currlanding.name + ".");
                        }
                    }
                    if (!success)
                        Console.WriteLine("You can't land there right now.");
                }
            } else
                Console.WriteLine("You can't do that here.");
        }

        public void depart(){
            if (currlanding != null){
                Console.WriteLine("You have departed from " + currlanding.name + ".");
                currlanding = null;
            } else
                Console.WriteLine("You can't do that here.");
        }

        public void jump(){
            if (currlanding == null){
                Console.WriteLine("Where would you like to jump to?\n");
                string starname = Console.ReadLine();
                bool success = false;
                if (starname != null){
                    starname = starname.ToLower();
                    foreach (System cyclesystem in Game.allsystems){
                        if (cyclesystem.name.ToLower() == starname){
                            success = true;
                            System destination = cyclesystem;
                            /*
                            distx = currsystem.coordinates.x - destination.coordinates.x
                            disty = currsystem.coordinates.y - destination.coordinates.y
                            distz = currsystem.coordinates.z - destination.coordinates.z
                            dist = (distx + disty + distz) / 3
                            */
                            currsystem = destination;
                            Console.WriteLine("You have jumped to " + currsystem.name + ".");
                        }
                    }
                }
                if (!success)
                    Console.WriteLine("You can't jump there right now.");
            } else
                Console.WriteLine("You can't do that here.");
        }

        public void reputation(){
            Console.WriteLine("Which faction would you like to view?\n");
            string facname = Console.ReadLine().ToLower();
            bool success = false;
            if (facname != null){
                foreach (Faction cyclefaction in Game.allfactions){
                    if (cyclefaction.name.ToLower() == facname){
                        success = true;
                        Faction viewfaction = cyclefaction;
                        Console.WriteLine("Your reputation with " + viewfaction.name + " is at " + viewfaction.reputation.ToString() + "%");
                        if (viewfaction.reputation <= 10)
                            Console.WriteLine("They are hostile towards you.");
                        if (viewfaction.reputation >= 50)
                            Console.WriteLine("You can purchase ships from them.");
                        if (viewfaction.reputation >= 35)
                            Console.WriteLine("You can purchase outfits from them.");
                        if (viewfaction.reputation >= 25)
                            Console.WriteLine("You can land on their landings.");
                    }
                }
            }
            if (!success)
                Console.WriteLine("That faction doesn't exist.");
        }

        public void balance(){
            Console.WriteLine("You have " + money.ToString() + " credits.");
        }

        public void viewShip(){
            if (ship == null)
                Console.WriteLine("You don't have a ship.");
            else {
                uint shipval = ship.cost;
                foreach (Outfit cycleoutfit in ship.outfits){
                    shipval += cycleoutfit.cost;
                    Console.WriteLine("Name: " + ship.name);
                    Console.WriteLine("Class: " + ship.category);
                    Console.WriteLine("Mass: " + ship.mass.ToString());
                    Console.WriteLine("Outfit Space: " + ship.space[0].ToString() + "/" + ship.space[1].ToString());
                    Console.WriteLine("Weapon Space: " + ship.weapon[0].ToString() + "/" + ship.weapon[1].ToString());
                    Console.WriteLine("Value: " + shipval.ToString() + " credits");
                    Console.WriteLine("OUTFITS:");
                }
                Engine enginetemp;
                Weapon weapontemp;
                foreach (Outfit cycleoutfit in ship.outfits){
                    string specialtext = "";
                    if (cycleoutfit is Engine){
                        enginetemp = (Engine)cycleoutfit;
                        specialtext = " Thrust: " + enginetemp.thrust.ToString();
                    } else if (cycleoutfit is Weapon) {
                        weapontemp = (Weapon)cycleoutfit;
                        specialtext = " Power: " + weapontemp.power.ToString();
                    Console.WriteLine(cycleoutfit.name + ": Cost: " + cycleoutfit.cost.ToString() + " Space: " + cycleoutfit.space.ToString() + specialtext);
                    }
                }
            }
        }

        public void services(){
            if (currlanding != null){
                bool hasnothing = true;
                if (currlanding.shipyard){
                    Console.WriteLine("This Landing has a shipyard.");
                    hasnothing = false;
                }
                if (currlanding.outfitter){
                    Console.WriteLine("This Landing has an outfitter.");
                    hasnothing = false;
                }
                if (hasnothing)
                    Console.WriteLine("This Landing has no services.");
            else
                Console.WriteLine("You can't do that here.");
            }
        }

        public void help(){
            Console.WriteLine("COMMANDS:");
            Console.WriteLine("Buy Ship (Req. Shipyard)\nSell Ship (Req. Shipyard)");
            Console.WriteLine("Buy Outfit (Req. Outfitter) Sell Outfit (Req. Outfitter)");
            Console.WriteLine("Services (Req. On landing)\nDepart (Req. On landing)\nLand (Req. In system)\nJump (Req. In system)");
            Console.WriteLine("Rename Pilot\nRename Ship\nReputation\nBalance\nShip\nHelp");
        }
    }
}