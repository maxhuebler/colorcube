using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
	float platformSpeed = 2f;

	float startPoint;
	bool endPoint;
	float endPointY;

	public int unitsToMove = 2;

	void Start()
	{
		startPoint = transform.position.y;
		endPointY = startPoint + unitsToMove;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (endPoint)
		{
			transform.position += Vector3.up * platformSpeed * Time.deltaTime;
		}
		else
		{
			transform.position -= Vector3.up * platformSpeed * Time.deltaTime;
		}
		if (transform.position.y >= endPointY)
		{
			endPoint = false;
		}
		if (transform.position.y <= startPoint)
		{
			endPoint = true;
		}
	}
}
