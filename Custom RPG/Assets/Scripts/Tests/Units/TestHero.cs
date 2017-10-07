using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestHero : UnitObj {
	override public void Init(){
		InitVars ();
		logic.InitBars (100, 75, 10);
		logic.speed.Init (5);
		UpdateBarsText ();

	}

	public void InitVars(){
		logic = new UnitLogic();
		sprite = new TestHeroSprite();
		sprite.Init();

	}

}
