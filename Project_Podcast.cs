class Podcast
{ 
    //List i which the Episodes are going to be stored
    private List<Episode> episodes = new List<Episode>();

    //Constructor of the podcast
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    //Property that stores the name of the podcast
    public string Name { get; }

    //Property that stores the name of the host
    public string Host { get; }

    //Property that calculates the total number of episodes
    public int TotalEpisodes => episodes.Count;

    //Method that adds a new podcast to the list
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    //Method that displays the podcast information
    public void DisplayInformation()
    {
        Console.WriteLine($"{Name}, by {Host}:");
        foreach (var episode in episodes.OrderBy(e => e.EpisodeNumber))
        {
            Console.WriteLine($"· {episode.Title}");
        }
        Console.WriteLine($"{TotalEpisodes} Total Episodes.");

    }
}
