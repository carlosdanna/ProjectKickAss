using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {

	public float resetPoint = -574;
	public float beginPoint = 228;
	public float y;
	public float currentPoint;
	public float scrollVelocity;
	public GameObject mainMenu;
	public GameObject creditsMenu;
	public GameObject text;

	// Update is called once per frame
	void Update ()
	{
		Vector3 vec = Vector3.zero;
		currentPoint += Time.deltaTime * scrollVelocity;

		vec.y = Time.deltaTime * scrollVelocity;
		text.transform.Translate(vec);

		if(currentPoint <= resetPoint)
		{
			BacktoMainMenu();
		}
	
	}

	void BacktoMainMenu()
	{
		currentPoint = beginPoint;
		mainMenu.SetActive(true);
		creditsMenu.SetActive(false);
	}
}
