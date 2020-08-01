using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public Rigidbody bullet;//Сама пуля
    public Transform SpawnPoint; // Точка вылета пули
    private float ShootTimer = 0.0f;
    public float ShootSpeed; // Скорострельность 
    private int random;
 
    [SerializeField] private List<ForceBullet> force;

    // Update is called once per frame
    void Update()
    {       
        if (ShootTimer > 0)
        {
            ShootTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0) & ShootTimer <= 0)
        {
            {
                random = Random.Range(0, force.Count);
               
                Rigidbody BulletInstance;
                BulletInstance = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation) as Rigidbody;
                BulletInstance.AddForce(SpawnPoint.forward * random);
                ShootTimer = ShootSpeed;
                
            }
        }

       
    }
}
