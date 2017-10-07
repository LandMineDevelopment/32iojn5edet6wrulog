using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour {
	enum Type : byte {Physical, Chemical, Magic, Pure};
	int moo = (int)Type.Physical;

	void Start(){
		print (moo);
	}
}
