using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitObj : MonoBehaviour {
	public UnitLogic logic;
	public UnitSprite sprite;

	public void UpdateBarsText(){
		sprite.bars.hp.GetComponent<Text>().text = "HP: " + logic.hp.Val.ToString();
		sprite.bars.mana.GetComponent<Text>().text = "Mana: " + logic.mana.Val.ToString();
		sprite.bars.energy.GetComponent<Text> ().text = "Energy: " + logic.energy.Val.ToString();
	}

	public virtual void Init(){}

}
