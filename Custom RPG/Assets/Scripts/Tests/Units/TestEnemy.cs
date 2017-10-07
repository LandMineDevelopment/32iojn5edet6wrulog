using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : UnitObj {
	override public void Init(){
		InitVars ();
		logic.InitBars (100, 75, 10);
		logic.speed.Init (5);
		UpdateBarsText();
	}

	public void InitVars(){
		logic = new UnitLogic();
		sprite = new TestEnemySprite();
		sprite.Init();
	}
}
