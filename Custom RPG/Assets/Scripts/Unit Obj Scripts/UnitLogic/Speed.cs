using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed {
	private int val;
	private int counter;


	//################################# Set/Get variables
	public int Val{
		get{return val;}
		set{val = value;}
	}

	public int Counter{
		get{return counter;}
	}


	//################################# Other functions
	public void ResetCounter(){
		counter = val;
	}

	public void IncrementCounter(){
		counter += val;
	}

	public void Init(int value){
		val = value;
		counter = value;
	}
}
