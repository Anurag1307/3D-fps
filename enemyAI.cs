using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {
	public Transform Character;
	static Animator anim;
	public GameObject bloodEffect;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update (){
		if(Vector3.Distance(Character.position, this.transform.position)<80)
		{
			Vector3 direction = Character.position - this.transform.position;
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
				Quaternion.LookRotation(direction), 0.1f);

			anim.SetBool("isIdle",false);
			if(direction.magnitude >10)
			{
				this.transform.Translate(0,0,0.1f);
				anim.SetBool("isWalking",true);
				anim.SetBool("isAttacking",false);
			}
			else
			{
				anim.SetBool("isWalking",false);
				anim.SetBool("isAttacking",true);
			
				StartCoroutine (EnemyAttackDamage ());
			}
		}
		else{
				anim.SetBool("isIdle",true);
				anim.SetBool("isWalking",false);
				anim.SetBool("isAttacking",false);
		}
	}
	IEnumerator EnemyAttackDamage() {
		bloodEffect.SetActive (true);
		yield return new WaitForSeconds (.05f);
		bloodEffect.SetActive (false);
		GlobalHealth.CharacterHealth -= 1; //create a global health C# Script that stores health of character and a characterHealth variable
		yield return new WaitForSeconds (6);

	}


}