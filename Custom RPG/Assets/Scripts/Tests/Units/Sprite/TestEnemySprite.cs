using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemySprite : UnitSprite {
	override public void Init(){
		canvas = Instantiate(Resources.Load("CanvasTemplate")) as GameObject;
		bars = new BarSprite("EnemyHP","EnemyMana","EnemyEnergy", canvas);
	}
}
