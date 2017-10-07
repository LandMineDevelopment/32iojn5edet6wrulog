using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum Effects : byte {Burn, Poison, Slow, Corrosion, Silence, Break, Sleep, Ground, Stun, Total};
public static class EffectList { 
	private static Effect[] effects = new Effect[System.Enum.GetValues(typeof(Effects)).Length];

	//get statuses
	public static Effect GetEffect(int effect){
		return effects[effect];
	}
}


