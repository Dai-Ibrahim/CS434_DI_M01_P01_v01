//This script handles what happens if the player hits an obstacle.
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	//Define public variables
	public PlayerMovement movement;
	
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") //Check if the object is tagged as an obstacle.
		{
			movement.enabled = false; // disable palyer movement.
			FindObjectOfType<GameManager>().EndGame(); //End the game.

		}
    }


}
