class Character
{
    const int maxPowerPoints = 250;
    int usedPowerPoints { get; set; }

    public string name { get; set; }
    public int hp { get; set; }
    public int currentHp;
    public int attack { get; set; }
    public int defense { get; set; }
    public int speed { get; set; }
    public Types type1{ get; set; }
    public Types type2{ get; set; }
    public Move[] moves { get; set; }

    public Character()
    {
        moves = new Move[2];
    }

    public bool setName(string name)
    {
        if (checkStringLenght(name))
        {
            this.name = name;
            return true;
        }
        return false;
    }

    public bool setHp(int hp)
    {
        if (checkUserPowerRemaining(hp))
        {
            this.hp = hp;
            return true;
        }
        return false;
    }

    public bool setAttack(int attack)
    {
        if (checkUserPowerRemaining(attack))
        {
            this.attack = attack;
            return true;
        }
        return false;
    }

    public bool setDefense(int def)
    {
        if (checkUserPowerRemaining(def))
        {
            this.defense = def;
            return true;
        }
        return false;
    }

    public bool setSpeed(int speed)
    {
        if (checkUserPowerRemaining(speed))
        {
            this.speed = speed;
            return true;
        }
        return false;
    }

    bool checkUserPowerRemaining(float newPowerPoints)
    {
        if (usedPowerPoints + newPowerPoints > maxPowerPoints)
        {
            Console.WriteLine("To many power points used, you can reduce power points for other attribrutes or use less powerpoints here. PowerPoints left:" + (maxPowerPoints - usedPowerPoints));
            return false;
        }
        usedPowerPoints += (int)newPowerPoints;
        Console.WriteLine("The value is set");
        return true;
    }
    public int powerRemaining()
    {
        return maxPowerPoints - usedPowerPoints;
    }
    bool checkStringLenght(string userString)
    {
        if (userString.Length >= 4 && userString.Length <= 20)
        {
            return true;
        }
        return false;
    }
}