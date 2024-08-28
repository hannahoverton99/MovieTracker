using System;

namespace MovieTracker.Classes;

public class User
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public Profile UserProfile {get; set;}
}
