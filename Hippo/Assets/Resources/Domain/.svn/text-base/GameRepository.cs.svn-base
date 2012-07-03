using System;
using System.Collections.Generic;
using System.Linq;

public class GameRepository
{
    private static readonly Dictionary<string, Game> Games = new Dictionary<string, Game>();
    private static int _tagNumber;

    private static string NextTag()
    {
        return (++_tagNumber).ToString("00");
    }

    public Game Get()
    {
        return Games.Values.FirstOrDefault() ?? Create();
    }

    public Game Get(string tag)
    {
        Game instance;
        Games.TryGetValue(tag, out instance);
        return instance ?? Create();
    }

    public Game Create()
    {
        var game = new Game();
        Save(NextTag(), game);
        return game;
    }
    
    public void Save(string tag, Game game)
    {
        if(Games.ContainsKey(tag))
            throw new Exception("A game with that tag already exists.");

        Games.Add(tag, game);
    }

    public void Delete(string tag)
    {
        if(Games.ContainsKey(tag))
            Games.Remove(tag);
    }
}