using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisioneroScript : MonoBehaviour {

    Animator miAnimator;

	void Start () {
        miAnimator = GetComponent<Animator>();
	}
	
	void Update () {
        float y = Input.GetAxis("Vertical");
        miAnimator.SetFloat("corriendo", y);

        if (Input.GetKeyDown(KeyCode.Space)) {
            miAnimator.SetBool("estaAndando", true);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            miAnimator.SetBool("estaAndando", false);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            miAnimator.SetTrigger("punch");
        }

	}

    public void ReproducirSonidoPisada() {
        print("ESTOY ANDANDO");
    }
}
