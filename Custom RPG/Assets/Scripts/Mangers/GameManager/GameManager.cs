using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	BattleManager battle;
	WorldManager world;
	MenuManager menu;
	MusicManager music;

	int toggle;

	bool end;

	// Use this for initialization
	void Start () {
		battle = new BattleManager();
		world = new WorldManager();
		menu = new MenuManager();
		music = new MusicManager();

		end = false;

		toggle = Mode.World;

		while (!end) {
			if (toggle == Mode.World)
				toggle = menu.RunMenu ();
			else if (toggle == Mode.Battle)
				toggle = battle.RunBattle ();
			else if(toggle == Mode.Menu)
				toggle = world.RunWorld ();
		}
	}
	

}
