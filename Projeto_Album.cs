class Album 
{
    private List<Song> songs = new List<Song>();
    public string Name { get; set; }

    public int TotalDuration => songs.Sum(s => s.Duration);

    public void AddSong(Song song) 
    {
        songs.Add(song);
    }

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
