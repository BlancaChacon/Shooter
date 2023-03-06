using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [Tooltip("Prefab de Enemigo a generar")]
    public GameObject prefab;

    [Tooltip("Tiempo en el que se inicia y finaliza la oleada")]
    public float starTime, endTime;
    
    [Tooltip("Tiempo entre la generación de enemigos")]
    public float spawnRate;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",starTime,spawnRate);
        Invoke("CancelInvoke",endTime);
    }


    void SpawnEnemy()
    {
        //Quaternion q = Quaternion.Euler(x:0,y:transform.rotation.eulerAngles.y + Random.Range(-45.0f, 45.0f), z:0);
        
        Instantiate(prefab, transform.position, transform.rotation);
    }
}

