using System.Text.Json;

Dictionary<Types, Dictionary<Types, float>> typeChart = new()
{
    {Types.Programmer, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 2},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 1},
            {Types.Unity, 2},
            {Types.Godot, 2},
            {Types.LBS, 1},
            {Types.NTI, 1},
            {Types.Nörd, 0},
            {Types.Anarkist, 1},
        }
    },

    {Types.Skeleton, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 0.5f},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 2},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 1},
            {Types.NTI, 1},
            {Types.Nörd, 1},
            {Types.Anarkist, 2},
        }
    },

    {Types.Estetare, new Dictionary<Types, float>()
        {
            {Types.Programmer, 0},
            {Types.Skeleton, 1},
            {Types.Estetare, 1},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 2},
            {Types.Unity, 0.5f},
            {Types.Godot, 0.5f},
            {Types.LBS, 2},
            {Types.NTI, 1},
            {Types.Nörd, 0},
            {Types.Anarkist, 2},
        }
    },

    {Types.Nynäshamnare, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 1},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 2},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 1},
            {Types.NTI, 1},
            {Types.Nörd, 1},
            {Types.Anarkist, 2},
        }
    },

    {Types.Kalkon, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 2},
            {Types.Estetare, 1},
            {Types.Nynäshamnare, 0},
            {Types.Kalkon, 1},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 2},
            {Types.NTI, 2},
            {Types.Nörd, 0.5f},
            {Types.Anarkist, 0.5f},
        }
    },

    {Types.Unity, new Dictionary<Types, float>()
        {
            {Types.Programmer, 0.5f},
            {Types.Skeleton, 1},
            {Types.Estetare, 2},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 1},
            {Types.Unity, 1},
            {Types.Godot, 0},
            {Types.LBS, 2},
            {Types.NTI, 2},
            {Types.Nörd, 2},
            {Types.Anarkist, 1},
        }
    },

    {Types.Godot, new Dictionary<Types, float>()
        {
            {Types.Programmer, 2},
            {Types.Skeleton, 0.5f},
            {Types.Estetare, 2},
            {Types.Nynäshamnare, 0.5f},
            {Types.Kalkon, 0},
            {Types.Unity, 2},
            {Types.Godot, 1},
            {Types.LBS, 2},
            {Types.NTI, 2},
            {Types.Nörd, 2},
            {Types.Anarkist, 0},
        }
    },

    {Types.LBS, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 0},
            {Types.Nynäshamnare, 2},
            {Types.Kalkon, 1},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 1},
            {Types.NTI, 0},
            {Types.Nörd, 2},
            {Types.Anarkist, 0.5f},
        }
    },

    {Types.NTI, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 0},
            {Types.Nynäshamnare, 1},
            {Types.Kalkon, 2},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 2},
            {Types.NTI, 1},
            {Types.Nörd, 2},
            {Types.Anarkist, 0.5f},
        }
    },

    {Types.Nörd, new Dictionary<Types, float>()
        {
            {Types.Programmer, 2},
            {Types.Skeleton, 0.5f},
            {Types.Estetare, 0},
            {Types.Nynäshamnare, 0.5f},
            {Types.Kalkon, 0.5f},
            {Types.Unity, 1},
            {Types.Godot, 1},
            {Types.LBS, 2},
            {Types.NTI, 1},
            {Types.Nörd, 2},
            {Types.Anarkist, 0},
        }
    },

    {Types.Anarkist, new Dictionary<Types, float>()
        {
            {Types.Programmer, 1},
            {Types.Skeleton, 1},
            {Types.Estetare, 1},
            {Types.Nynäshamnare, 2},
            {Types.Kalkon, 1},
            {Types.Unity, 0.5f},
            {Types.Godot, 0.5f},
            {Types.LBS, 2},
            {Types.NTI, 2},
            {Types.Nörd, 1},
            {Types.Anarkist, 0},
        }
    }
};

string moveFileName = "moves.txt";
string characterFileName = "character.txt";

List<Move> moves;
List<Character> Characters;

string title = @"                                                                                                                                              
 _____    _____ _____ _____ _____ _____ _____ _____ _____ _____    _____ _____ _____ _____ _____    _____ _____ _____ ____  _____ _____ _____ _____ _____ 
|  _  |  |_   _|  |  | __  |     |  |  |     |     |   __|   __|  |   __|  _  |     |   __|   __|  |  _  | __  |  |  |    \|  |  |     |_   _|     |     |
|     |    | | |  |  |    -|  |  |  |  |  |  |-   -|__   |   __|  |  |  |     | | | |   __|__   |  |   __|    -|  |  |  |  |  |  |   --| | | |-   -|  |  |
|__|__|    |_| |_____|__|__|__  _|_____|_____|_____|_____|_____|  |_____|__|__|_|_|_|_____|_____|  |__|  |__|__|_____|____/|_____|_____| |_| |_____|_____|                                                                                                                       

";

Random rand = new Random();


loadData();
gameManager();

void gameManager()
{
    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    //Console.SetWindowPosition(Console.LargestWindowHeight,Console.LargestWindowWidth);
    Console.WriteLine(title);
    Thread.Sleep(1000);
    Console.Clear();

    Console.WriteLine("ARE YOU READY");
    Thread.Sleep(1000);
    Console.Clear();
    while (true)
    {
        Console.WriteLine("WHAT DO YOU WANT TO DO CHALLENGER");
        Console.WriteLine("A: PLAY");
        Console.WriteLine("B: EDIT CHARECHTERS");
        Console.WriteLine("C: EDIT MOVES");
        Console.WriteLine("D: QUIT");

        string reps = Console.ReadLine();
        if (reps.ToUpper() == "A")
        {
            Console.Clear();
            Play();
        }
        else if (reps.ToUpper() == "B")
        {
            Console.Clear();
            characterEditor();
        }
        else if (reps.ToUpper() == "C")
        {
            Console.Clear();
            moveEditor();
        }
        else if (reps.ToUpper() == "D")
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Enter a valid option please");
        }
    }
    writeData();
}

/*
Micke Prog NÖRD
Maxi Anarkist
NEO Skelet
Sam Nynäsham Prog
Java Prog
NTI-Estetare NTI eset
LBS-Estetare LBS est
Kalkonis Kalkon
Unity Unity 
Godot Godot
Alien Godot Anarkist
*/

#region Play

void Play()
{
    while (true)
    {
        Console.WriteLine("What mode do you want to play?");
        Console.WriteLine("A: Player vs Bot");
        Console.WriteLine("B: Player vs Player");

        string reps = Console.ReadLine();
        if (reps.ToUpper() == "A")
        {
            Console.Clear();
            playAgianstBot();
        }
        else if (reps.ToUpper() == "B")
        {

        }
        else
        {
            Console.WriteLine("You cant choose that");
        }
    }
}

void playAgianstBot()
{
    Console.WriteLine("YOU HAVE CHOOSEN DEATH");
    Console.WriteLine("");
    Console.WriteLine("Choose your character");

    Character bot = Characters[rand.Next(0, Characters.Count)];
    bot.currentHp = bot.hp;
    Character player;

    printCurrentCharacters();

    while (true)
    {
        string reps = Console.ReadLine();
        int value = 0;
        if (int.TryParse(reps, out value))
        {
            if (value >= 0 || value <= Characters.Count)
            {
                player = Characters[value];
                Console.WriteLine("YOU CHOOSE " + player.name);
                player.currentHp = player.hp;
                break;
            }
            else
            {
                Console.WriteLine("That is not an option");
            }
        }
        else
        {
            Console.WriteLine("That is not an option");
        }
    }
    Console.WriteLine("BEGIN THE FIGHT");

    while (true)
    {
        if (player.speed > bot.speed)
        {
            humanRound(player, bot);
            if (bot.hp > 0)
            {
                win(player, bot);
            }
            botRound(player, bot);
            if (player.hp > 0)
            {
                win(bot, player);
            }
        }
        else
        {
            botRound(player, bot);
            if (player.hp > 0)
            {
                win(bot, player);
            }
            humanRound(player, bot);
            if (bot.hp > 0)
            {
                win(player, bot);
            }
        }
    }
}

void playAgianstHuman()
{

}

void humanRound(Character player, Character opponent)
{

}

void botRound(Character player, Character bot)
{
    Move botMove = bot.moves[rand.Next(0, bot.moves.Length)];

    Console.WriteLine("Bots turn");
    Console.WriteLine("The Bot attacks with " + botMove.name);

    int attackPower = bot.attack * botMove.power;

}

void win(Character winner, Character loser)
{

}


#endregion

#region dataSystem


void loadData()
{
    if (File.ReadAllText(moveFileName).Length == 0)
    {
        moves = new List<Move>();
    }
    else
    {
        moves = JsonSerializer.Deserialize<List<Move>>(File.ReadAllText(moveFileName));
    }

    if (File.ReadAllText(characterFileName).Length == 0)
    {
        Characters = new List<Character>();
    }
    else
    {
        Characters = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText(characterFileName));
    }
}

void writeData()
{
    try
    {
        using (StreamWriter writer = new StreamWriter(moveFileName))
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            string strJson = JsonSerializer.Serialize<List<Move>>(moves, opt);
            writer.Write(strJson);
        }
    }
    catch (Exception exp)
    {
        Console.Write(exp.Message);
    }

    try
    {
        using (StreamWriter writer = new StreamWriter(characterFileName))
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            string strJson = JsonSerializer.Serialize<List<Character>>(Characters, opt);
            writer.Write(strJson);
        }
    }
    catch (Exception exp)
    {
        Console.Write(exp.Message);
    }
}
#endregion

#region playerEditor
void characterEditor()
{
    while (true)
    {
        Console.WriteLine("Welcome to the Character Editor here you can");
        Console.WriteLine("A: Look at current character");
        Console.WriteLine("B: Delete a current character");
        Console.WriteLine("C: Add a Character");
        Console.WriteLine("D: Go Back \n");

        string reps = Console.ReadLine();

        if (reps.ToUpper() == "A")
        {
            Console.Clear();
            printCurrentCharacters();
        }
        else if (reps.ToUpper() == "B")
        {
            Console.Clear();
            deleteCharacter();
        }
        else if (reps.ToUpper() == "C")
        {
            Console.Clear();
            addCharacter();
        }
        else if (reps.ToUpper() == "D")
        {
            Console.Clear();
            return;
        }
        else
        {
            Console.WriteLine("That is not an option try agian");
            Console.Clear();
        }
    }
}

bool printCurrentCharacters()
{
    if (checkIfCharacterArrayExist())
    {
        for (int i = 0; i < Characters.Count; i++)
        {
            Console.WriteLine(i + ": " + Characters[i].name);
            Console.WriteLine("    HP: " + Characters[i].hp);
            Console.WriteLine("    Attack: " + Characters[i].attack);
            Console.WriteLine("    Defense: " + Characters[i].defense);
            Console.WriteLine("    Speed: " + Characters[i].speed);
            Console.WriteLine("    Moves:");
            Console.WriteLine("        " + Characters[i].moves[0].name);
            Console.WriteLine("        " + Characters[i].moves[1].name);
            Console.WriteLine("");
        }
        return true;
    }
    return false;
}

void deleteCharacter()
{
    if (printCurrentCharacters())
    {
        Console.WriteLine("\n Select the number of the Character you want to delete");
        string reps = Console.ReadLine();
        for (int i = 0; i < moves.Count; i++)
        {
            if (reps == i.ToString())
            {
                Console.WriteLine("Deleting that Character now!");
                Characters.Remove(Characters[i]);
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        Console.WriteLine("You didint enter in a valid number going back");
        Thread.Sleep(1000);
        Console.Clear();
    }
}

void addCharacter()
{
    Console.WriteLine("You have 250 points to spend on hp, Attack, Defence and speed");
    Character character = new Character();

    setCharacterName(character);
    Console.WriteLine("");
    setCharacterHp(character);
    Console.WriteLine("");
    setCharacterAttack(character);
    Console.WriteLine("");
    setCharacterDefence(character);
    Console.WriteLine("");
    setCharacterSpeed(character);
    Console.WriteLine("");
    setCharacterType(character);
    Console.WriteLine("");
    addCharacterMoves(character);
    Console.WriteLine("");
    Characters.Add(character);

    Console.WriteLine("Character Added");
    Thread.Sleep(1000);
    Console.Clear();
}

void setCharacterName(Character character)
{
    while (true)
    {
        Console.WriteLine("What is the name of the Character 4-20 letters");
        string name = Console.ReadLine();
        if (character.setName(name))
        {
            break;
        }
        Console.WriteLine("That name is not valid try agian");
    }
}

void setCharacterHp(Character character)
{
    while (true)
    {
        Console.WriteLine("What is the hp of the character");
        Console.WriteLine("Power points remaning " + character.powerRemaining().ToString());
        string hp = Console.ReadLine();

        int hpValue = 0;
        if (int.TryParse(hp, out hpValue))
        {
            if (character.setHp(hpValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Power points exedeed");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid hp");
        }

    }
}

void setCharacterAttack(Character character)
{
    while (true)
    {
        Console.WriteLine("What is the power of the attack");
        Console.WriteLine("Power points remaning " + character.powerRemaining().ToString());
        string attack = Console.ReadLine();

        int attackValue = 0;
        if (int.TryParse(attack, out attackValue))
        {
            if (character.setAttack(attackValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Power points exedeed");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid attack");
        }

    }
}

void setCharacterDefence(Character character)
{
    while (true)
    {
        Console.WriteLine("What is the power of the defense");
        Console.WriteLine("Power points remaning " + character.powerRemaining().ToString());
        string defense = Console.ReadLine();

        int defenseValue = 0;
        if (int.TryParse(defense, out defenseValue))
        {
            if (character.setDefense(defenseValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Power points exedeed");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid defense");
        }
    }
}

void setCharacterSpeed(Character character)
{
    while (true)
    {
        Console.WriteLine("What is the speed of the move");
        Console.WriteLine("Power points remaning " + character.powerRemaining().ToString());
        string speed = Console.ReadLine();

        int speedValue = 0;
        if (int.TryParse(speed, out speedValue))
        {
            if (character.setSpeed(speedValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Power points exedeed");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid speed");
        }

    }
}

void setCharacterType(Character character)
{
    while (true)
    {
        Console.WriteLine("Which type is the Character");
        int count = 0;
        foreach (KeyValuePair<Types, Dictionary<Types, float>> kvp in typeChart)
        {
            Console.WriteLine(count + " " + kvp.Key.ToString());
            count++;
        }
        string type = Console.ReadLine();

        int typeValue = 0;
        if (int.TryParse(type, out typeValue))
        {
            if (typeValue >= 0 && typeValue <= 11)
            {
                character.type1 = (Types)Enum.ToObject(typeof(Types), typeValue);
                break;
            }
            else
            {
                Console.WriteLine("Theese move dosent exists");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid type");
        }
    }

    while (true)
    {
        Console.WriteLine("Which is the second type, type none if you dont want any");
        int count = 0;
        foreach (KeyValuePair<Types, Dictionary<Types, float>> kvp in typeChart)
        {
            Console.WriteLine(count + " " + kvp.Key.ToString());
            count++;
        }
        string type = Console.ReadLine();

        if (type.ToUpper() == "NONE"){
            character.type2 = Types.none;
            break;
        }

        int typeValue = 0;
        if (int.TryParse(type, out typeValue))
        {
            if (typeValue >= 0 && typeValue <= 11)
            {
                character.type2 = (Types)Enum.ToObject(typeof(Types), typeValue);
                break;
            }
            else
            {
                Console.WriteLine("Theese move dosent exists");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid type");
        }
    }
}

void addCharacterMoves(Character character)
{
    for (int i = 0; i < character.moves.Length; i++)
    {
        while (true)
        {
            Console.WriteLine("Select the number of the move you want to add:");

            List<Move> possibleMoves = new();

            int trueCount = 0;
            for (int j = 0; j < moves.Count; j++)
            {
                if (moves[j].type == character.type1 || moves[j].type == character.type2)
                {
                    possibleMoves.Add(moves[j]);
                    Console.WriteLine(trueCount + ": " + moves[j].name);
                    Console.WriteLine("    Power:" + moves[j].power.ToString());
                    Console.WriteLine("    Accurecy:" + moves[j].accuracy.ToString());
                    Console.WriteLine("");
                    trueCount++;
                }
            }


            string resp = Console.ReadLine();

            int moveIndex = 0;
            if (int.TryParse(resp, out moveIndex))
            {
                if (moveIndex >= 0 && moveIndex < possibleMoves.Count)
                {
                    Console.WriteLine("Move Added");
                    character.moves[i] = possibleMoves[moveIndex];
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid value");
                }
            }
            else
            {
                Console.WriteLine("Not a Valid value");
            }
        }
    }
}

bool checkIfCharacterArrayExist()
{
    if (Characters == null || Characters.Count == 0)
    {
        Console.WriteLine("There are no characters, try adding some");
        return false;
    }
    return true;
}

#endregion

#region MoveEditor

void moveEditor()
{
    while (true)
    {
        Console.WriteLine("Welcome to the move Editor here you can");
        Console.WriteLine("A: Look at current moves");
        Console.WriteLine("B: Delete a current move");
        Console.WriteLine("C: Add a move");
        Console.WriteLine("D: Go Back \n");

        string reps = Console.ReadLine();

        if (reps.ToUpper() == "A")
        {
            Console.Clear();
            printCurrentMoves();
        }
        else if (reps.ToUpper() == "B")
        {
            Console.Clear();
            deleteMoves();
        }
        else if (reps.ToUpper() == "C")
        {
            Console.Clear();
            addMove();
        }
        else if (reps.ToUpper() == "D")
        {
            Console.Clear();
            return;
        }
        else
        {
            Console.WriteLine("That is not an option try agian");
            Console.Clear();
        }
    }
}

bool printCurrentMoves()
{
    if (checkIfMovesArrayExist())
    {
        for (int i = 0; i < moves.Count; i++)
        {
            Console.WriteLine(i + ": " + moves[i].name);
            Console.WriteLine("    Power:" + moves[i].power.ToString());
            Console.WriteLine("    Accurecy:" + moves[i].accuracy.ToString());
        }
        Console.WriteLine("");
        return true;
    }
    Console.WriteLine("");
    return false;
}

void deleteMoves()
{
    if (printCurrentMoves())
    {
        Console.WriteLine("\n Select the number of the move you want to delete");
        string reps = Console.ReadLine();
        for (int i = 0; i < moves.Count; i++)
        {
            if (reps == i.ToString())
            {
                Console.WriteLine("Deleting that move now!");
                moves.Remove(moves[i]);
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        Console.WriteLine("You didint enter in a valid number going back");
        Thread.Sleep(1000);
        Console.Clear();
    }
}

void addMove()
{
    Console.WriteLine("You have 25 points to spend on power and accuracy. Each power point is worth 1 and each accuracy point is worth x*7");

    Move move = new Move();

    setMoveName(move);
    Console.WriteLine("");
    setMovePower(move);
    Console.WriteLine("");
    setMoveAccuracy(move);
    Console.WriteLine("");
    setType(move);
    Console.WriteLine("");
    moves.Add(move);
    Console.WriteLine("Move Added");
    Thread.Sleep(1000);
    Console.Clear();
}

void setMoveName(Move move)
{
    while (true)
    {
        Console.WriteLine("What is the name of the move 4-20 letters");
        string name = Console.ReadLine();
        if (move.setName(name))
        {
            break;
        }
        Console.WriteLine("That name is not valid try agian");
    }
    Console.WriteLine("Name is set");
}

void setMovePower(Move move)
{
    while (true)
    {
        Console.WriteLine("What is the power of the move");
        Console.WriteLine("Power points remaning " + move.powerRemaining().ToString());
        string power = Console.ReadLine();

        int powerValue = 0;
        if (int.TryParse(power, out powerValue))
        {
            if (move.setPower(powerValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Power points exedeed");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid power");
        }

    }
    Console.WriteLine("Power is set");
}

void setMoveAccuracy(Move move)
{
    while (true)
    {
        Console.WriteLine("What is the Accuracy of the move 0-1");
        Console.WriteLine("Power points remaning " + move.powerRemaining().ToString());
        string accuracy = Console.ReadLine();

        float accuracyValue = 0;
        if (float.TryParse(accuracy, out accuracyValue))
        {
            if (move.setAccuracy(accuracyValue))
            {
                break;
            }
            else
            {
                Console.WriteLine("Not a valid number or power points exceeded");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid Accuracy");
        }

    }
    Console.WriteLine("Accurcy is set");
}

void setType(Move move)
{
    while (true)
    {
        Console.WriteLine("Which type is the move");
        int count = 0;
        foreach (KeyValuePair<Types, Dictionary<Types, float>> kvp in typeChart)
        {
            Console.WriteLine(count + " " + kvp.Key.ToString());
            count++;
        }
        string type = Console.ReadLine();

        int typeValue = 0;
        if (int.TryParse(type, out typeValue))
        {
            if (typeValue >= 0 && typeValue <= 11)
            {
                move.setType((Types)Enum.ToObject(typeof(Types), typeValue));
                break;
            }

            else
            {
                Console.WriteLine("Theese move dosent exists");
            }
        }
        else
        {
            Console.WriteLine("That is not a valid type");
        }

    }
    Console.WriteLine("Type is set");
}

bool checkIfMovesArrayExist()
{
    if (moves == null || moves.Count == 0)
    {
        Console.WriteLine("There are no moves, try adding some");
        return false;
    }
    return true;
}
#endregion

#region Types
public enum Types { Programmer, Skeleton, Estetare, Nynäshamnare, Kalkon, Unity, Godot, LBS, NTI, Nörd, Anarkist, none };
#endregion
