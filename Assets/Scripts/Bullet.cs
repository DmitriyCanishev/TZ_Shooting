using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float live = 5.0f;
    public float timer = 0.0f;
    Vector3 bulletLastPos;


    public void Start()
    {
        bulletLastPos = transform.position;
        //GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;
    }

    public void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        bulletLastPos = transform.position;

        timer += Time.deltaTime;
        if(live < timer)
        {
            Destroy(gameObject);
        }
        


    }
}
