using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

	public float moveForce = 27;
	 public float jumpForce = 4;
	public Rigidbody2D playerRb;
	public bool isGrounded =false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(Input.GetKey(KeyCode.D) && isGrounded == true)
		{
			playerRb.AddForce(Vector2.right * moveForce);
		
		}
	 if(Input.GetKey(KeyCode.Space) && isGrounded == true)
		{
			isGrounded = false;
			playerRb.AddForce(Vector2.up * jumpForce);
			
		}
		if (Input.GetKey(KeyCode.A) && isGrounded == true)
		{
			playerRb.AddForce(Vector2.left	 * moveForce);
			
		}
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
			isGrounded = true;
	}
}
