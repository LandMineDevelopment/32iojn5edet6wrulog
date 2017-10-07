using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlHero {
	private int lvl; //Hero level
	private float times, power, add; //used to create function that determines Hero level based on xp

	public int getLvl{
		get{
			return lvl;
		}
		set{
			while (value >= times * Mathf.Pow (lvl, power) + add)
				lvl++;
		}
	}

	public void setMods(float newTimes, float newPower,float newAdd){
		times = newTimes;
		power = newPower;
		add = newAdd;
	}
			
}
