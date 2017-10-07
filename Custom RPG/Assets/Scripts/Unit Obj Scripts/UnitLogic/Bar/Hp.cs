using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : Bar {
	//check if the UnitLogic is alive
	public bool isAlive{
		get{return val > 0 ? true : false;}
	}		
}
