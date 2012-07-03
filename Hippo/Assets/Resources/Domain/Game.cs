using System;
using System.Linq;

public class Game
{
	public Game()
    {
        this.Preferences = new Preferences();
		this.Hippos = new Hippo[] { 
			new Hippo(Tag.Hippo1, "Pink"),
			new Hippo(Tag.Hippo2, "Red"),
			new Hippo(Tag.Hippo3, "Green"),
			new Hippo(Tag.Hippo4, "Yellow")
		};
    }

    public Game(Preferences preferences, Hippo[] hippos)
    {
        this.Preferences = preferences;
		this.Hippos = hippos;
    }

    public Preferences Preferences { get; set; }
	
	public Hippo[] Hippos { get; private set; }
	
	public Hippo FindHippo(Tag tag) {
		return this.Hippos.FirstOrDefault(hippo => hippo.Tag == tag);
	}
		
}