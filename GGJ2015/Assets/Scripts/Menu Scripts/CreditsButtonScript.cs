using UnityEngine;
using System.Collections;

public class CreditsButtonScript : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject creditsMenu;
	// Use this for initialization
	public void GotoCredits()
	{
		mainMenu.SetActive(false);
		creditsMenu.SetActive(true);
	}
}
