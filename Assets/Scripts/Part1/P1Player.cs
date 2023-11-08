using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Player : MonoBehaviour
{

    private bool attacking = false;
    public p1Hitbox hitbox;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopAttack();
        }

        animator.SetBool("isAttacking", attacking);

    }

    void Attack()
    {
        animator.Play("Slash");
        attacking = true;
        hitbox.gameObject.SetActive(true);
        hitbox.StartAttack();
    }

    void StopAttack()
    {
        attacking = false;
    }
}
