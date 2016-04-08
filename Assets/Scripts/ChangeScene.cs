using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public Transform button;

	public void ChangeToScene (string sceneToChangeTo)
	{
		SceneManager.LoadScene(sceneToChangeTo);
	}
}
