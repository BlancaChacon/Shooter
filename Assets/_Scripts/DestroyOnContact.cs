using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeOnContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        //Destroy(gameObject); PROHIBIDO OBJECT POOLING ES MEJOR
        gameObject.SetActive(false); //ESTO DESACTIVA LA BALA
        if (other.CompareTag("Enemy") || other.CompareTag("Player"))
        {
            Destroy(other.gameObject); // ESTO DESACTIVA EL OTRO OBJETO SOLO PLAYER O ENEMIGO
        }
        
    }
}
