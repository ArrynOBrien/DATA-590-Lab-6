using UnityEngine;

public class PaddleScript : MonoBehaviour
{
	private GameObject ball;

	private void Start()
	{
		ball = GameObject.Find("Ball");
	}

	void FixedUpdate()
	{
		float paddle_speed = 0.1f;
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		if (Input.GetKey("left")) x -= paddle_speed;
		if (Input.GetKey("right")) x += paddle_speed;
		if (x < -2.5f) x = -2.5f;
		if (x > 2.5f) x = 2.5f;
		transform.position = new Vector3(x, y, z);
	}
	private void OnCollisionExit()
	{
		Vector3 v = ball.GetComponent<Rigidbody>().linearVelocity;
		ball.GetComponent<Rigidbody>().linearVelocity = new Vector3(v.x + Random.Range(-0.9f, 0.9f), v.y * 1.2f, 0);
	}

}
