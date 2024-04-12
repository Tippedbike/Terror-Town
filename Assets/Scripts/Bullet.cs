using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody bulletRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        bulletRb.AddForce(lookDirection * speed * Time.deltaTime);
    }
    //private void OnCollisionEnter(Collision other)
    //{
        // If bullet collides with player destroy it
       // if (other.gameObject.name == "Player")
       // {
            //Destroy(other.gameObject);
        //} 
    //}
}
