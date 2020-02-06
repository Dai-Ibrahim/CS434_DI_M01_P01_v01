//This script is responsible for the player movement mechanism
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Define all public variables 
	public Rigidbody rb;
   	public float forwardsForce = 2000f;
	public float sidewaysForce = 500f;

    void FixedUpdate()
    {
		//Add a forward force on the object 
        rb.AddForce(0,0,forwardsForce*Time.deltaTime);
		
		//Get user input and move object accordingly
		if (Input.GetKey("d"))
		{
			Command moveRight = new MoveRight(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveRight);
            invoker.ExecuteCommand();
		}
		if (Input.GetKey("a"))
		{
			Command moveLeft = new MoveLeft(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveLeft);
            invoker.ExecuteCommand();
		}
		//End game if the object falls off the platform
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();

		}
		
		

    }
}
