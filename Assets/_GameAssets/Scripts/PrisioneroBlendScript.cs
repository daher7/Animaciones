using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisioneroBlendScript : MonoBehaviour {

    Animator miAnimator;
    float corriendo = 0.1f;

    void Start() {
        miAnimator = GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            print("ANDANDO");
            // ANDA
            miAnimator.SetFloat("corriendo", 0.11f);
        }
        else if (!Input.GetKey(KeyCode.UpArrow)) {
            print("PARANDO");
            // SE PARA. Se suelta la tecla UpArrow. Esta andando o corriendo
            corriendo -= 0.01f;
            corriendo = Mathf.Max(0f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)) {
            print("CORRIENDO");
            // A CORRER
            corriendo += 0.01f;
            corriendo = Mathf.Min(1, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKeyUp(KeyCode.LeftShift)) {
            print("DEJANDO DE CORRER");
            // DEJA DE CORRER
            corriendo -= 0.01f;
            corriendo = Mathf.Max(0.11f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        }
        // Para girar la camara
        if (corriendo > 0.1f) {
            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        }
    }
}
