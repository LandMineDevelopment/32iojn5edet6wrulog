using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitSprite : MonoBehaviour {
	public GameObject canvas; //canvas where all sprite objects are drawn
	public BarSprite bars; //**Currently** contains the text for the Unit's bars 

	public virtual void Init(){}
}
