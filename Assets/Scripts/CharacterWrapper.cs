using UnityEngine;

public class CharacterWrapper : MonoBehaviour
{
	// Update is called once per frame
	void FixedUpdate()
	{
		if(transform.position.x <= -4.6f)
		{
			transform.position = new Vector3(4.6f, transform.position.y, transform.position.z);
		}
		else if(transform.position.x >= 4.6f)
		{
			transform.position = new Vector3(-4.6f, transform.position.y, transform.position.z);
		}
	}
}
