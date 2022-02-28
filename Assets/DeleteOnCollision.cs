using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCollision : MonoBehaviour
{
    public LayerMask LayerMask;


    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    
}
