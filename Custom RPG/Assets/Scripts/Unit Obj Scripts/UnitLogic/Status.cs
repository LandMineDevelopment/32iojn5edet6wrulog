using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status{
	public float resist; //chance that the will evade status 
	public int turns; //num of turns the status affects the unint
	public int efftNum;

	//decrements turns by 1
	public void Decrement(){
		turns += turns > 0 ? -1 : 0;
	} 

	//tells if logic is affected by status
	public bool IsAffected{
		get{return turns > 0 ? true : false;}
	}
		
}
