using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundButtonHit : MonoBehaviour
{
	void UpdateSound()
	{
		soundEnabled = !soundEnabled;
		button.image.sprite = (!soundEnabled) ? volumeSprite: muteSprite;
		AudioListener.pause = soundEnabled;
	}

	public bool soundEnabled = true;
	public Button button;
	public Sprite volumeSprite;
	public Sprite muteSprite;
}
