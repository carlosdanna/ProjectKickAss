using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	//public int score = 0;					// The player's score.
    public float time = 0f;

	//private PlayerControl playerControl;	// Reference to the player control script.
	//private int previousScore = 0;			// The score in the previous frame.


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
        guiText.text = time.ToString("   0.00") + " sec";

		//// If the score has changed...
		//if(previousScore != score)
		//	// ... play a taunt.
		//	playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		//previousScore = score;
	}

}
