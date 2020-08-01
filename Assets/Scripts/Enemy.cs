using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, Quaternion.identity);

        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }  
    
}
