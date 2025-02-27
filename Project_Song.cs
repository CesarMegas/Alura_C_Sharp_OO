class Song
{
    //Constructor of the song
    public Song(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }    
    
    //Property that stores the name of the song
    public string Name { get; }

    //Property that stores the artist of the song
    public Band Artist { get;}
    
    //Property that stores the duration of the song
    public int Duration { get; set; }
    
    //Property that stores the availability of the song
    public bool Available { get; set; }

    //Property that stores the genre of the song
    Genre Genre { get; set; }

    //Property that stores a short description of the song
    public string ShortDescription => $"The Song {Name} belongs to {Artist}.";

    //Method that displays a technical sheet of the band
    public void DisplayTechnicalSheet() 
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available on the Current Subscription.\n");
        }
        else {
            Console.WriteLine("Unavailable on the Current Subscription.\n");
        }
        Console.WriteLine();
    }
}
