using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitLogic{
	public Hp hp = new Hp();
	public Mana mana = new Mana();
	public Energy energy = new Energy();
	public Damage attk = new Damage();
	public Speed speed = new Speed();

	public Reduction[] reductions = new Reduction[(int)DmgMod.Total];
	public Status[] statuses = new Status[(int)Effects.Total];
	public StatType[] statTypes = new StatType[(int)Stats.Total];
	public SKill[] skills;

	public bool flying;
	public bool isRanged; //when false is meele
	public bool canCast;
	public bool canAttk;


	//################################# Initialize variables

	//Initialize values of all bars
	public virtual void InitBars(int newHp, int newMana, int newEnergy){
		hp.Init(newHp);
		mana.Init(newMana);
		energy.Init(newEnergy);
	}

	//initialize Arrays
	public virtual void InitArrays(){
		for(int elem = 0; elem < (int)DmgMod.Total; elem++){
			reductions[elem] = new Reduction();
		}
		for(int elem = 0; elem < (int)Effects.Total; elem++){
			statuses[elem] = new Status();
			statuses[elem].turns = 0;
		}
	}

	//################################# Status Functions

	public virtual void ImplementStatuses(){
		foreach (Status elem in statuses) {
			if (elem.IsAffected) {
				elem.Decrement();
				if (!elem.IsAffected)
					EffectList.GetEffect(elem.efftNum).Unapply(this);
			}	
		}
	} 

	//################################# Other Functions


	//take damage
	public virtual void TakeDmg(int raw, int dmgMod){
		float red = reductions[dmgMod].Red; 
		float redChan = reductions [dmgMod].RedChan;
		int block = reductions [dmgMod].Block;
		float blkChan = reductions[dmgMod].BlkChan;

		int totalRed = 0;

		if(redChan >= Random.value)
			totalRed = (int)(raw * red);
		if (blkChan >= Random.value)
			totalRed += block;
		this.hp.AddVal = totalRed - raw; //should be negative if taking damage and positive if healing
	}

	//take status
	public virtual void TakeStatus(UnitLogic caster, int efftNum){
		Status status = statuses [efftNum];
		if(status.resist < Random.value) { 
			EffectList.GetEffect(efftNum).Apply(this);
		}
	}

	public virtual void Action(){
	}

}
