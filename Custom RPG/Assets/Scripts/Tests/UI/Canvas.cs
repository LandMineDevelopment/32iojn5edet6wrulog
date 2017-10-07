using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {
	GameObject clone;
	GameObject text;


	void Start () {
		clone = Instantiate(Resources.Load("CanvasTemplate")) as GameObject;
		text = Instantiate(Resources.Load("HeroHP")) as GameObject;
		text.transform.SetParent(clone.transform, false);
		text.GetComponent<Text>().text = "Works!?!?";
	}
}
