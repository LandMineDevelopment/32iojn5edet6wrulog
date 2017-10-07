using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect {
	protected int efftNum; //number that corrilates with the enum identifier
	protected int turns;
	protected int lvl; //effect increases in strength based on effect lvl
	protected bool stacksTurn; //if true effect will add the number of turns to the exsisting number of turns instead of replace
	protected bool stacksEffect;

	//get variables
	public virtual int EfftNum{get{return efftNum;}}
	public virtual int Turns{get{return turns;}}
	public virtual int Lvl{get{return lvl;}}
	public virtual bool StacksTurns{get{return stacksTurn;}}
	public virtual bool StacksEffect{get{return stacksEffect;}}

	public virtual void Apply(UnitLogic target){
	}
	public virtual void Unapply(UnitLogic target){
	}
}
