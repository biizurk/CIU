using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PLaySoundOnTrigger : MonoBehaviour {


	public float fadeOutFactor = 0.1f;
	float audioVolume;
	
	void OnTriggerEnter(Collider other) 
	{
		audio.Play();
	}
	
	void OnTriggerExit() 
	{
		audio.Stop();
	}
	
	public void fadeIn()
	{
		if (audio.volume < 1)
		{
			audio.volume += 0.1f * Time.deltaTime;
		}
	}
	
	public void fadeOut()
	{
		if (audio.volume > 0.1)
		{
			audio.volume -= 0.1f * Time.deltaTime;
		}
	}
}
