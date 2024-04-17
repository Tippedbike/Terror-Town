using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
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
     }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}