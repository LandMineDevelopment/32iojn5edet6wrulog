using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarSprite : MonoBehaviour {
	public GameObject hp;
	public GameObject mana;
	public GameObject energy;

	public BarSprite(string hpName, string manaName, string energyName, GameObject parent){
		hp = Instantiate (Resources.Load (hpName)) as GameObject;
		mana = Instantiate (Resources.Load (manaName)) as GameObject;
		energy = Instantiate (Resources.Load (energyName)) as GameObject;

		hp.transform.SetParent(parent.transform, false);
		mana.transform.SetParent(parent.transform, false);
		energy.transform.SetParent(parent.transform, false);
	}
}
