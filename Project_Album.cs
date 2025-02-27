class Album 
{
    private List<Song> songs = new List<Song>();

    //Constructor of the album
    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }

    //Property that calculates the total duration of an album
    public int TotalDuration => songs.Sum(s => s.Duration);

    //Method that adds songs to an album
    public void AddSong(Song song) 
    {
        songs.Add(song);
    }

    //Method that displays all of the album's songs
    public void DisplayAlbumSongs() 
    {
        Console.WriteLine($"{Name} Song List:\n");
        foreach (var song in songs)
        {
            Console.WriteLine($"· {song.Name}");
        }
        Console.WriteLine($"\nThis Album has a Total Duration of {TotalDuration} seconds.");
    }
}
