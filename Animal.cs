class Animal{
    public string name;
    public string color;

    public bool hasLeg;

    public Animal(string animalName, string aniColor, bool hasLegg){
        name = animalName;
        color = aniColor;
        hasLeg = hasLegg;
    }

    public void DisplayAminal(){
        Console.WriteLine($"Animal name is {name} Animal Color is {color} and has leg {hasLeg}");
    }

    

}