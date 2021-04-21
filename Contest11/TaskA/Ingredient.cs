using System;

public class Ingredient
{
    public string Name { get; set; }

    protected int TimeToCook { get; set; }

    public Ingredient(string name, int timeToCook)
    {
        throw new NotImplementedException();
    }
}