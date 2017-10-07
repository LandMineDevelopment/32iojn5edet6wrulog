using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduction {
	private float red; //negate percent of damage
	private float redChan; //chance to reduce damage
	private int block; //negate amount of damage
	private float blkChan; //chance to block 

	//################################# Get/set variables

	//get/set red
	public float Red{
		get{return red;} 
		set{
			if (value > 1F)
				red = 1F;
			else if (value < -1F)
				red = -1F;
			else
				red = value;
		}
	}
	//get/set redChan
	public float RedChan{
		get{return redChan;} 
		set{
			if (value > 1F)
				redChan = 1F;
			else if (value < -1F)
				redChan = -1F;
			else
				redChan = value;
		}
	}
		
	//get/set block
	public int Block{
		get{return block;} 
		set{block = value;}
	}

	//get/set blkChan
	public float BlkChan{
		get{return blkChan;} 
		set{
			if (value > 1F)
				blkChan = 1F;
			else if (value < -1F)
				blkChan = -1F;
			else
				blkChan = value;
		}
	}

	public void SetAll(float newRed, float newRedChan, int newBlock, float newBlkChan){
		this.Red = newRed;
		this.RedChan = newRedChan;
		this.Block = newBlock;
		this.BlkChan = newBlkChan;
	}	
}
