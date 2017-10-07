using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatType{
	private int statNum;
	private int stat; //stat value
	private float statMod, statItem; 

	public int Stat{
		get{return stat;}

		set{ //takes level as input
			stat = (int)Mathf.Floor((float)value * (statMod + statItem)); 
		}
	}

	public float StatMod{
		get{return statMod;}
		set{statMod = value;}
	}

}
