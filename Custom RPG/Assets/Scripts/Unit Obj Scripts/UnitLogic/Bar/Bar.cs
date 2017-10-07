using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar {
	protected int val; 
	protected int max; 


	//################################# Get/Set variables  

	//get/set val
	public int Val{
		get{return val;}
		set{
			if (value > max)
				val = max;
			else if (value < 0)
				val = 0;
			else
				val = value;
		}
	}

	//get/set max
	public int Max{
		get{return max;}
		set{max = value;}
	}

	//################################# Add to variables

	//add to val
	public int AddVal{
		set{
			if ((val + value) > max)
				val = max;
			else if ((val + value) < 0)
				val = 0;
			else
				val += value;
		}
	}

	//add to max
	public int AddMax{
		set{max = (max + value) >= 0 ? (max + value) : 0;}
	}


	//################################# Change variables based on percentages 

	//sets val to percentage of max
	public void PercentMax(float percent){
		val = 0;
		this.Val = (int)((float)max*percent);
	}

	// adds percentage of max
	public void AddPercentMax(float percent){
		this.Val = (int)((float)max*percent);
	}

	//sets val to percentage of current val
	public void PercentCurrent(float percent){
		int oldVal = val;
		val = 0;
		this.Val = (int)((float)oldVal*percent);
	}

	//adds percentage of current val
	public void AddPercentCurrent(float percent){
		this.Val = (int)((float)val*percent);
	}


	//################################# Initialize variables

	//initializes val and max
	public void Init(int init){
		val = init;
		max = init;
	}
}
