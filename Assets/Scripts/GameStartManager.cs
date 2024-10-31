using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartManager : MonoBehaviour
{
	public void GameStart()
	{
		SceneManager.LoadScene("game");
	}
}
