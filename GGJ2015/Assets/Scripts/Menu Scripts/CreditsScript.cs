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

		if (text.transform.position.y >= resetPoint)
		{
			BacktoMainMenu();
		}
	
	}

	void BacktoMainMenu()
	{
		currentPoint = 0;
		Vector3 vec = Vector3.zero;
		vec.y = -(resetPoint - beginPoint + (text.transform.position.y-resetPoint));
		text.transform.Translate(vec);
		mainMenu.SetActive(true);
		creditsMenu.SetActive(false);
	}
}
