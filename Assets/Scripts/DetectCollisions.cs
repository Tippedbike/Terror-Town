using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
      public ParticleSystem explosionParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

     if(other.gameObject.CompareTag("Building"))
     {
       Destroy(other.gameObject);
       Destroy(gameObject);
       explosionParticles.Play(); 
     }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}