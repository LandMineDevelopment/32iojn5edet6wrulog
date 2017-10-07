using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPrioQ {
	private LinkedList<UnitObj> queue = new LinkedList<UnitObj> ();

	private LinkedList<UnitObj> Insert(UnitObj unitObj, LinkedList<UnitObj> q){
		LinkedListNode<UnitObj> node = new LinkedListNode<UnitObj> (null);
		if (q.First == null) {
			q.AddFirst (unitObj);
			return q;
		}
		else if (unitObj.logic.speed.Counter < (q.First.Value).logic.speed.Counter){
			q.AddFirst (unitObj);
			return q;
		}
		else{
			node = q.First;
			q.RemoveFirst();
			q = Insert (unitObj, q);
			q.AddFirst (node.Value);
			return q;
		}
	}

	public void InsertUnit(UnitObj unitObj){
		queue = Insert (unitObj, queue);
	}

	public UnitLogic First{get{return queue.First.Value.logic;}}

	public void ReInsertFirst(){
		if (queue.First.Value.logic.hp.Val <= 0)
			queue.RemoveFirst();
		else {
			UnitObj unitObj = new UnitObj ();
			unitObj = queue.First.Value;
			unitObj.logic.speed.IncrementCounter ();
			queue.RemoveFirst();
			queue = Insert (unitObj, queue);
		}
	}

		
}
