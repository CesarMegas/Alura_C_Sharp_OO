class Guest
{
    //Constructor of the guest
    public Guest(string name, string area)
    {
        Name = name;
        Area = area; 
    }

    //Property that stores the guest's name
    public string Name { get; }

    //Property that stores the guest's area
    public string Area { get; }

    //Property that displays a description of the guest
    public string Description => $"{Name}, {Area}.";
}
