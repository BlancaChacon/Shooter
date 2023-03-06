using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private float amount;


    public float Amount
    {
        get => amount;

        
        set
        {
            amount = value;

            if (amount <= 0)
            {
                Animator anim = GetComponent<Animator>();
                anim.SetTrigger("Play Die");

                Invoke("PlayDestruction", time:1);

                Destroy(gameObject, t:2);
            }
        }
    }

    
    void PlayDestruction()
    {
        ParticleSystem explotion = GetComponentInChildren<ParticleSystem>();
        explotion.Play();
    }
}