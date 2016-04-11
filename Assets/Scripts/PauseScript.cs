using UnityEngine;

public class PauseScript : MonoBehaviour
{
	bool paused;

	// Use this for initialization
	void Start()
	{
		paused = false;
	}
	
	public void Pause()
	{
		paused = !paused;

		if (paused)
		{
			Time.timeScale = 0;
		}
		else if (!paused)
		{
			Time.timeScale = 1;
		}
	}
}
