using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestHeroSprite : UnitSprite {

	override public void Init(){
		canvas = Instantiate(Resources.Load("CanvasTemplate")) as GameObject;
		bars = new BarSprite("HeroHp","HeroMana","HeroEnergy", canvas);
	}
}
