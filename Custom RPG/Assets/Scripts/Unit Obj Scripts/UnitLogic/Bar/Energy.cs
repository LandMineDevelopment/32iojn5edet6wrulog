using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : Bar {
	private int regenerate;
	public void regen(){
		val += regenerate;
	}
}
