using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    Animator anim;
    bool isCLose = false;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}

    private void OnMouseDown()
    {
        isCLose = !isCLose;
        anim.SetBool("IsClose", isCLose);
    }

}
