using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            animator.SetTrigger("RoundKick");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        
            animator.SetTrigger("Run");
        
    }

}