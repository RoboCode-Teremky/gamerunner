using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{



    [SerializeField] private float speed = 1.0f;
    //[SerializeField] private float dashForce = 1.0f;
    private Rigidbody2D rb;
    void Start()
    {
    //    rb = GetComponent<Rigidbody2D>();
    
    }


    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetMouseButtonDown(1))
      //  {
       //     speed *= 2;
  
      //  }
        transform.Translate(Vector2.left*speed*Time.deltaTime);
      
    }
 private IEnumerator WaitForASecond(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    

}
