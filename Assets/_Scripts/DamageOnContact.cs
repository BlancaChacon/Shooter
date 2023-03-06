using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
        public float damage;
    
        private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        //Destroy(gameObject); PROHIBIDO OBJECT POOLING ES MEJOR
        gameObject.SetActive(false); //ESTO DESACTIVA LA BALA
        /* if (other.CompareTag("Enemy") || other.CompareTag("Player"))
        {
            Destroy(other.gameObject); // ESTO DESACTIVA EL OTRO OBJETO SOLO PLAYER O ENEMIGO
        } */

        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.Amount -= damage;//life.amount = life.amount - damage;

        }

        

    }
}
