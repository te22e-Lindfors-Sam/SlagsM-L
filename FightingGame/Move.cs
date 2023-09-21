using System.Diagnostics;

class Move{
    const int maxPowerPoints = 25;
    int usedPowerPoints = 0;

    public string name = "Unamed Move";
    public int power = 10;
    public int accuracy = 1;
    public statusEffect statusEffect = statusEffect.none;

    public Move(){}

    public void setName(String name) {
        this.name = name;
    }
    public void setPower(int power) {
        if (checkUserPowerRemaining(power)){
            this.power = power;
        }
    }
    public void setAccuracy(int accuracy) {
        this.accuracy = accuracy;
    }
    public void setStatusEffects(statusEffect userStatusEffect) {
        if (userStatusEffect == statusEffect.none) {
            this.statusEffect = statusEffect.none;
            return;
        }
        else if (checkUserPowerRemaining(10)){
            this.statusEffect = userStatusEffect;
            return;
        }
    }

    bool checkUserPowerRemaining(int newPowerPoints){
        if (usedPowerPoints + newPowerPoints > maxPowerPoints) {
            Console.WriteLine("To many power points used, you can reduce power points for other attribrutes or use less powerpoints here. PowerPoints left:" + (maxPowerPoints-usedPowerPoints));
            return false;
        }
        Console.WriteLine("The value is set");
        return true;
    }

bool checkStringLenght(string userString){
    if (userString.Length >= 4 && userString.Length <= 10){
        return true;
    }
    return false;
}

}

public enum statusEffect{Posion, Burn, none}