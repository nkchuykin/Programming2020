using System.Runtime.Serialization;

[DataContract]
public class Vegetable : Ingredient
{
    [DataMember]
    public bool IsAllergicTo { get; set; }

    public Vegetable(string name, int timeToCook, bool isAllergicTo) : base(name, timeToCook)
    {
        IsAllergicTo = isAllergicTo;
    }

}