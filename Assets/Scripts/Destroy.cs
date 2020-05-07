using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

	public float timer = 1f;

	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			Destroy(gameObject);
		}
	}
}
