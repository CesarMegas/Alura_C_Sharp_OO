class Episode
{
    //List that stores the guests' names 
    private List<Guest> guests = new List<Guest>();

    //Constructor of the episode
    public Episode(string title, int episodeNumber, int duration)
    {
        Title = title;
        EpisodeNumber = episodeNumber;
        Duration = duration;
    }

    //Property that stores the title of the episode
    public string Title { get; }

    //Property that stores the number of the episode
    public int EpisodeNumber { get; }

    //Property that stores the duration of the episode
    public int Duration { get; }

    //Property that shows a description of the episode
    public string Description => $"Episode number {EpisodeNumber}: {Title}. {Duration} minutes. Guests: {GetGuestsNames()}";

    //Method that combines the guests' names
    private string GetGuestsNames()
    {
        return string.Join(", ", guests.Select(g => g.Name));
    }

    //Method that adds guests to the episode
    public void AddGuests(Guest guest)
    {
        guests.Add(guest);
    }
}
