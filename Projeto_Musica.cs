class Song
{
    //Property that stores the name of the song
    public string Name {  get; set; }

    //Property that stores the artist of the song
    public string Artist { get; set; }
    
    //Property that stores the duration of the song
    public int Duration { get; set; }
    
    //Property that stores the availability of the song
    public bool Available { get; set; }

    //Property that stores a short description of the song
    public string ShortDescription => $"The Song {Name} belongs to {Artist}.";

    public void DisplayTechnicalSheet() 
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available on the Current Subscription.");
        }
        else {
            Console.WriteLine("Unavailable on the Current Subscription.");
        }
        Console.WriteLine();
    }
}
