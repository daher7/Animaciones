using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtunScript : MonoBehaviour {

    public void Mueve() {
        //this.transform.Translate(Vector3.forward * 10);
        this.GetComponentInParent<Transform>().Translate(Vector3.forward * 10);
    }
}
