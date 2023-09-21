
class Move
{
    const int maxPowerPoints = 25;
    int usedPowerPoints { get; set; }

    public string name  { get; set; }
    public int power { get; set; }
    public float accuracy { get; set; }
    public Types type{ get; set; }

    public Move() { }

    public bool setName(String name)
    {
        if (checkStringLenght(name)){
            this.name = name;
            return true;
        }
        return false;
    }
    public bool setPower(int power)
    {
        if (checkUserPowerRemaining(power))
        {
            this.power = power;
            return true;
        }
        return false;
    }
    public bool setAccuracy(float accuracy)
    {
        if (accuracy <= 1 && accuracy >= 0){
            if (checkUserPowerRemaining(accuracy * 7)){
                this.accuracy = accuracy;
                return true;
            }
        }
        return false;
    }

    public void setType(Types type){
        this.type = type;
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

    bool checkStringLenght(string userString)
    {
        if (userString.Length >= 4 && userString.Length <= 20)
        {
            return true;
        }
        return false;
    }

    public int powerRemaining(){
        return maxPowerPoints-usedPowerPoints;
    }
}
