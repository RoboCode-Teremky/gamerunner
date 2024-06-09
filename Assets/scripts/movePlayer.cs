using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{

    public float jumpForce = 1.0f;


    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.down,2.0f);
        if(Input.GetKey(KeyCode.Space) && hit.collider != null)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
