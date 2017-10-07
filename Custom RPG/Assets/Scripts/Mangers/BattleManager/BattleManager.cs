using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager {
	public UnitPrioQ turnOrder = new UnitPrioQ();
	public List<UnitObj> heros = new List<UnitObj>(); 
	public List<UnitObj> enemies = new List<UnitObj>();

	public void Turn(){
		turnOrder.First.Action ();
		turnOrder.ReInsertFirst ();
	}

	public void Clear(){
		turnOrder = new UnitPrioQ();
		heros = new List<UnitObj>(); 
		enemies = new List<UnitObj>();
	}

	public int RunBattle(){
	}
}
