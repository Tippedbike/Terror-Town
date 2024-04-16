using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
      public ParticleSystem explosionParticles;
      private bool buildingGone;
    // Start is called before the first frame update
    void Start()
    {
        buildingGone = false;
        explosionParticles.Stop(); 
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

     if(other.gameObject.CompareTag("Building"))
     {
       Destroy(other.gameObject);
       Destroy(gameObject);
       buildingGone = true; 
     }
    if(buildingGone == true)
     {
      explosionParticles.Play(); 
     }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}