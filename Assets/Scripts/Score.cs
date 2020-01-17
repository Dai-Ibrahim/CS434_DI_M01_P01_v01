//This script handles the scoring system of the game.
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	//Define public variables
	public Transform player;
	public Text scoreText;
	
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //As the player travels further on the z axis, their score will increase.
    }
}
