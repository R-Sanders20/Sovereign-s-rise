using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponController : MonoBehaviour
{
   // private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;

    public GameObject Axe;
    public bool CanAttack = true;
    public float AttackCoolDown = 1.0f;

    //void Update()
    //{
        
    //}
    public void AxeSwing ()
    { 
        CanAttack= false;
        Animator anim = Axe.GetComponent<Animator>();
        anim.SetTrigger("Swing");
        StartCoroutine(ResetAttackCoolDown());
        Debug.Log("Swing");
    }
    IEnumerator ResetAttackCoolDown()
    {
        yield return new WaitForSeconds(AttackCoolDown);
        CanAttack = true;
    }
}
