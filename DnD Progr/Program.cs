using System;

namespace DnD_Character_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WindowHeight = 50;
            Console.WindowWidth = 150;

            Console.WriteLine("You wake up in a haze, an unidentifiable mist in which you hold no form. A voice is heard, it asks that you state your name.");

            Player player1 = new Player("Player's Name");

            string _name = Console.ReadLine();

            Console.WriteLine("So, " + _name + ", says the voice... And exactly what are you?\n" + "Choose your race:\n");

            string _race = new Race("Player's Race");

            Random random = new Random();
            for(int dieRoll = 0; dieRoll < 0; dieRoll++)
            {
                Console.WriteLine(random.Next(20) + 1);

                if(dieRoll > 0 && <= 6)
                {
                    Console.WriteLine("The outcome of your die roll is" + dieRoll);
                }
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}

class Player
{
    public string _name;

    public Player (string name)
    {
        _name = name;
    }

    // Classes for every race the player gets to choose from:

    class Race
    {
        public string _race;

        public Race (string _race)
        {
            _race = race;
        }
    
    
        class Dragonborn
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;

                private Dragonborn()
                {
                    _strengthMod = 2;
                    _dexterityMod = 0;
                    _constitutionMod = 0;
                    _intelligenceMod = 0;
                    _wisdomMod = 0;
                    _charismaMod = 1;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Dwarf
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;

                private Dwarf()
                {
                    _strengthMod = 2;
                    _dexterityMod = 0;
                    _constitutionMod = 0;
                    _intelligenceMod = 0;
                    _wisdomMod = 0;
                    _charismaMod = 0;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Elf
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Elf()
                {
                    _strengthMod = 0;
                    _dexterityMod = 2;
                    _constitutionMod = 0;
                    _intelligenceMod = 0;
                    _wisdomMod = 0;
                    _charismaMod = 0;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }

            }

            class Gnome
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;
            
                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Gnome()
                {
                    _strengthMod = 0;
                    _dexterityMod = 0;
                    _constitutionMod = 0;
                    _intelligenceMod = 2;
                    _wisdomMod = 0;
                    _charismaMod = 0;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Halfling
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Halfling()
                {
                    
                    _strengthMod = 0;
                    _dexterityMod = 2;
                    _constitutionMod = 0;
                    _intelligenceMod = 0;
                    _wisdomMod = 0;
                    _charismaMod = 0;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Half_Orc
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Half_Orc()
                {
                    _strengthMod = 2;
                    _dexterityMod = 0;
                    _constitutionMod = 1;
                    _intelligenceMod = 0;
                    _wisdomMod = 0;
                    _charismaMod = 0;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Human
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;
            
                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Human()
                {
                    _strengthMod = 1;
                    _dexterityMod = 1;
                    _constitutionMod = 1;
                    _intelligenceMod = 1;
                    _wisdomMod = 1;
                    _charismaMod = 1;
                    
                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
            }

            class Tiefling
            {
                private int _strengthMod;
                private int _dexterityMod;
                private int _constitutionMod;
                private int _intelligenceMod;
                private int _wisdomMod;
                private int _charismaMod;

                private int _strengthSavingThrowMod;
                private int _dexteritySavingThrowMod;
                private int _constitutionSavingThrowMod;
                private int _intelligenceSavingThrowMod;
                private int _wisdomSavingThrowMod;
                private int _charismaSavingThrowMod;
                
                private Tiefling ()
                {
                    _strengthMod = 0;
                    _dexterityMod = 0;
                    _constitutionMod = 0;
                    _intelligenceMod = 1;
                    _wisdomMod = 0;
                    _charismaMod = 2;

                    _strengthSavingThrowMod = 0;
                    _dexteritySavingThrowMod = 0;
                    _constitutionSavingThrowMod = 0;
                    _intelligenceSavingThrowMod = 1;
                    _wisdomSavingThrowMod = 0;
                    _charismaSavingThrowMod = 2;
                }
        }
    }
}