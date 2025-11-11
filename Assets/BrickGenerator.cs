using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
	public GameObject BrickPrefab;
	void Start()
	{
		if (BrickPrefab)
		{
			for (int y = 0; y < 3; y++)
			{
				for (int x = 0; x <= 10; x++)
				{
					GameObject b = Instantiate(BrickPrefab, new Vector3(-2.5f + 0.5f * x, 4.5f + y * 0.25f, 0), Quaternion.identity);
					if (y == 0) b.GetComponent<MeshRenderer>().material.color = Color.blue;
					if (y == 1) b.GetComponent<MeshRenderer>().material.color = Color.red;
					if (y == 2) b.GetComponent<MeshRenderer>().material.color = Color.green;
				}
			}
		}
	}
}
