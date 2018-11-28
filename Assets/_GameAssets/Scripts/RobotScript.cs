using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {

    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 100.0f;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        // Movement
        if(translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", translation);
        } else
        {
            anim.SetBool("isWalking", false);
            anim.SetFloat("characterSpeed", 0);
        }
        if (Input.GetKeyDown("space"))
        {
            anim.SetTrigger("isJumping");
        }
	}
}
