using UnityEngine;
using UnityEngine.Rendering;

public class BallScript : MonoBehaviour
{
	public float Volume = 3;
	private void OnCollisionEnter()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot(audio.clip, Volume);
	}
}