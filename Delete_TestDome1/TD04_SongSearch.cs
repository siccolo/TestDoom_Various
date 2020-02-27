using System;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        Song song = this;
        Song next = this.NextSong;

        while (song != null && next != null)
        {
            if (ReferenceEquals(song, next))
                return true;

            song = song.NextSong;
            next = next.NextSong?.NextSong;
        }

        return false;
    }

    public static void Check()
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}