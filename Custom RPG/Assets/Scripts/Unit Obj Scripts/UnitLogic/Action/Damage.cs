using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : Action {
	private int dmgType;
	private int minDmg;
	private int maxDmg;


	//################################# Get/Set variables 

	//get/set dmgMod
	public int DmgType{
		get{return dmgType;}
		set{dmgType = (value < (int)DmgMod.Total || value < 0) ? value : 0;}
	}

	//get/set minDmg
	public int MinDmg{
		get{return minDmg;}
		set{minDmg = value > maxDmg ? maxDmg : value;}
	}

	//get/set maxDmg
	public int MaxDmg{
		get{return maxDmg;}
		set{maxDmg = value < minDmg ? minDmg : value;}
	}

	//sets all values
	public void SetAll(int mod, int min, int max){
		this.DmgType = mod;
		minDmg = min;
		maxDmg = max;
		this.MinDmg = min;
		this.MaxDmg = max;
	}

	//################################# Add to min/max damage 

	//add to minDmg
	public int AddMinDmg{
		set{minDmg = (minDmg + value) > maxDmg ? maxDmg : (minDmg + value);}
	}




	//################################# Other Functions 

	public void Dmg (UnitLogic def){
		int raw = Random.Range (minDmg, maxDmg);
		def.TakeDmg(raw, dmgType);
	}
}
