using UnityEngine;

public class BrickScript : MonoBehaviour
{
	private GameObject particles;

	private void Start()
	{
		particles = GameObject.Find("Explosion");
	}

	private void OnCollisionExit()
	{
		gameObject.SetActive(false);

		if (particles)
		{
			particles.transform.SetPositionAndRotation(transform.position, transform.rotation);
			particles.transform.localScale = transform.localScale;
			ParticleSystem ps = particles.GetComponent<ParticleSystem>();
			ps.Play();
		}
	}
}
