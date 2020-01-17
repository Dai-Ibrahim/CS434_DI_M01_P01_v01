//This script handles the camera movement with respect to the player.
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	//Define public variables
	public Transform player;
	public Vector3 offset;
    void Update()
    {
        transform.position=player.position + offset; // follow the player with an offset
    }
}
