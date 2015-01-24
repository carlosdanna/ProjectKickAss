using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public float time = 0f;					// The player's score.


	//private PlayerControl playerControl;	// Reference to the player control script.


	void Awake ()
	{
        
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		// Set the score text.
        time += Time.deltaTime;
        int intTime = (int)time;
        guiText.text = time.ToString("0.0") + " sec";

		//// If the score has changed...
		//if(previousScore != score)
		//	// ... play a taunt.
		//	playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
	}

}
