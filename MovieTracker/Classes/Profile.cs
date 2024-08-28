using System;

namespace MovieTracker.Classes;

public class Profile
{
    public int Id {get; set;}
    public string Username {get; set;}
    public List<Films> WatchedMovies {get; set;} = new List<Films>();
}
