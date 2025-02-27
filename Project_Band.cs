class Band
{
    //Constructor of the band
    public Band(string name)
    {
        Name = name;
    }

    //List in which the bands are going to be stored
    private List<Album> albums = new List<Album>();
    
    public string Name { get;}

    Genre Genre { get; set; }

    //Method that adds an album on the band
    public void AddAlbum (Album album)
    {
        albums.Add(album);
    }

    //Method that displays the discography of the band
    public void DisplayDiscography()
    {
        Console.WriteLine($"Discography of the Band {Name}:");
        foreach (Album album in albums) 
        {
            Console.WriteLine($"· {album.Name} ({album.TotalDuration} seconds total)");
        }
    }
}
