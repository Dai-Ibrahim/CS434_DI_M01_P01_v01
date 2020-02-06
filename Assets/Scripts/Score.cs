//This script handles the scoring system of the game.
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	//Define public variables
	public Transform player;
	public Text scoreText;
	public Text CommandText;
	Command command;

	
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //As the player travels further on the z axis, their score will increase.
		if(CommandLog.commands.Count > 0)
		{
			Debug.Log(CommandLog.commands.Count);
			command = CommandLog.commands.Dequeue();
			CommandText.text = command.ToString();
//			Debug.Log(ToString(command));
//			Debug.Log(CommandLog.commands.Count);
		}
		
    }
}
