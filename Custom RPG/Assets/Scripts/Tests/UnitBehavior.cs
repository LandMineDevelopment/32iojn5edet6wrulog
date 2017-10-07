using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitBehavior : MonoBehaviour { 
	public UnitObj attaker;
	public UnitObj defender;
	public BattleManager bm;


	// Use this for initialization
	void Start () {

		attaker = new TestHero();
		defender = new TestEnemy();
		bm = new BattleManager();

		attaker.Init();
		defender.Init();

		bm.turnOrder.InsertUnit (attaker);
		bm.turnOrder.InsertUnit (defender);
		print ("Queue First Speed: " + bm.turnOrder.First.speed.Val);
		print ("Queue First SpeedCounter: " + bm.turnOrder.First.speed.Counter);
		print ("//////////////////////////////////////////////");
		print ("Attaker Speed: " + attaker.logic.speed.Val);
		print ("Attaker SpeedCounter: " + attaker.logic.speed.Counter);
		print ("//////////////////////////////////////////////");
		print ("Defender Speed: " + defender.logic.speed.Val);
		print ("Defender SpeedCounter: " + defender.logic.speed.Counter);
		print ("##############################################");

		bm.turnOrder.ReInsertFirst ();
		bm.turnOrder.ReInsertFirst ();
	
		print ("Queue First Speed: " + bm.turnOrder.First.speed.Val);
		print ("Queue First SpeedCounter: " + bm.turnOrder.First.speed.Counter);
		print ("//////////////////////////////////////////////");
		print ("Attaker Speed: " + attaker.logic.speed.Val);
		print ("Attaker SpeedCounter: " + attaker.logic.speed.Counter);
		print ("//////////////////////////////////////////////");
		print ("Defender Speed: " + defender.logic.speed.Val);
		print ("Defender SpeedCounter: " + defender.logic.speed.Counter);

	}
}
