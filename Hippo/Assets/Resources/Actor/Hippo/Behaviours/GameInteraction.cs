using System;
using UnityEngine;

public class GameInteraction : MonoBehaviour {
	
	public Tag PlayerTag;
		
	private Game _game;
	private Hippo _hippo;
	
	void Awake () {
		_game = new GameRepository().Get();
		_hippo = _game.FindHippo(PlayerTag);
		if(_hippo == null)
			print(String.Format("Hippo not found '{0}'", PlayerTag));
	}
	
	void EatBall () {
		_hippo.EatBall();
	}
}
