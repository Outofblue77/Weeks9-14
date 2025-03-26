using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightMovement : MonoBehaviour
{
    Animator animator;
    SpriteRenderer sr;
    public AudioSource runningFootSteps;
    public float speed = 2;
    public bool canRun = true;
    public bool falling = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {

        float direction = Input.GetAxis("Horizontal");
        float height = Input.GetAxis("Vertical");

        sr.flipX = (direction < 0);

        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("jump");
            canRun = true;
            transform.position += transform.up * height * speed * Time.deltaTime;
        }
        if (falling == true)
        {
            animator.SetTrigger("fall");
            canRun = true;
        }

        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
            falling = false;
        }
    }

    public void AttackHasFinished()
    {
        canRun = true;
    }

    public void FootStep()
    {
        runningFootSteps.Play();
        canRun = true;
    }

    public void JumpHasFinished()
    {
        falling = true;
    }



}
