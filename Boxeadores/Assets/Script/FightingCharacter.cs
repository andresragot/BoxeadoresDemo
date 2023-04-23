using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingCharacter : MonoBehaviour
{
    [SerializeField]
    public GameObject characterOBJ;

    Animator anim;

    public bool isBlocking;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isBlocking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack1();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            Attack2();
        }

        if (Input.GetButton("Fire2"))
        {
            isBlocking = true;
            anim.SetBool("Blocking", isBlocking);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            isBlocking = false;
            anim.SetBool("Blocking", isBlocking);
        }



    }

    public void Attack1()
    {
        anim.SetTrigger("Punch");
        isBlocking = false;
        anim.SetBool("Blocking", isBlocking);
    }

    public void SetBlocking()
    {
        if (isBlocking)
        {
            isBlocking = false;
        }
        else
        {
            isBlocking = true;
        }

        anim.SetBool("Blocking", isBlocking);
    }

    public void Attack2()
    {
        anim.SetTrigger("Kick");
        isBlocking = false;
        anim.SetBool("Blocking", isBlocking);
    }
}
