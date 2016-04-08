using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Transform player;
	float playerHeightY;

	public Transform bluePlatform;
	public Transform redPlatform;
	public Transform greenPlatform;

	public GameObject menu;
	public GameObject score;
	public GameObject pause;

	private int platNumber;

	private float platCheck;
	private float spawnPlatformTo;

	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		player = GameObject.FindGameObjectWithTag("Player").transform;

		PlatformSpawner(-4f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		playerHeightY = player.position.y;

		if (playerHeightY > platCheck)
		{
			PlatformManager();
		}

		float currentCameraHeight = transform.position.y;

		float newHeightOfCamera = Mathf.Lerp(currentCameraHeight, playerHeightY, Time.deltaTime * 10);

		if (playerHeightY > currentCameraHeight)
		{
			transform.position = new Vector3(transform.position.x, newHeightOfCamera, transform.position.z);
		}
		else
		{
			if(playerHeightY < (currentCameraHeight - 20f))
			{
				Time.timeScale = 0;
				ShowScoreboard();
			}
		}

		if(playerHeightY > ScoreManager.score)
		{
			ScoreManager.score = (int)playerHeightY;
		}
	}

	void PlatformManager()
	{
		platCheck = player.position.y + 15;
		PlatformSpawner(platCheck + 15);
	}

	void PlatformSpawner(float floatValue)
	{
		float y = spawnPlatformTo;

		while (y <= floatValue)
		{
			float x = Random.Range(-4.364f, 4.364f);
			platNumber = Random.Range(0, 3);

			Vector2 posXY = new Vector2(x, y);

			if (platNumber == 0)
			{
				Instantiate(redPlatform, posXY, Quaternion.identity);
			}
			if (platNumber == 1)
			{
				Instantiate(bluePlatform, posXY, Quaternion.identity);
			}
			if (platNumber == 2)
			{
				Instantiate(greenPlatform, posXY, Quaternion.identity);
			}
			y += Random.Range(4f, 7f);
		}
		spawnPlatformTo = floatValue;
	}

	void ShowScoreboard()
	{
		ScoreManager.CheckHighScore();
		menu.SetActive(true);
		score.SetActive(false);
		pause.SetActive(false);
	}
}

