using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMove : MonoBehaviour
{

 [SerializeField] float speed = 1.0f;
 
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
}
