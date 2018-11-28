using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisioneroScript : MonoBehaviour {

    Animator miAnimator;

	void Start () {
        miAnimator = GetComponent<Animator>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)) {
            miAnimator.SetBool("estaAndando", true);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            miAnimator.SetBool("estaAndando", false);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            miAnimator.SetTrigger("punch");
        }
	}
}
