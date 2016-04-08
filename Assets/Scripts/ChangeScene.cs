using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void ChangeToScene (string sceneToChangeTo)
	{
		SceneManager.LoadScene(sceneToChangeTo);
	}

	public void RestartScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
