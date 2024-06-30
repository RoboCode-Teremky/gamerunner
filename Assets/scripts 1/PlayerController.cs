using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f; 
   // [SerializeField] private int jupCounnt = 0;
    private Rigidbody2D rb;
    private bool isGrounded; 
    [SerializeField] private int dashhhold;
    private bool coroutineRunning = false;
    //[SerializeField] public TMP_Text DashText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashhhold=1;
        StartCoroutine(IncrementDashhhold());
    }

    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
      if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
      {
           Dash();
       }
    }

        private IEnumerator IncrementDashhhold()
    {
        coroutineRunning = true;
        while (true)
        {
            yield return new WaitForSeconds(7f);
            dashhhold++;
        //    UpdateBonusText();
        }
    }

    void Jump()
    {
      
        if (isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false; 
            
        }
    }

   void Dash()
    {
        if(dashhhold >= 1)
        {
        rb.velocity = Vector2.left * jumpForce;
        dashhhold -=1;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.CompareTag("map"))
        {
            isGrounded = true;
        
        }
    }
   // private void UpdateBonusText()
   /// {
      // DashText.text = "dashhhold: " + dashhhold.ToString(); 
  //  }



        private void OnDestroyDash()
    {
        coroutineRunning = false;
    }

}
