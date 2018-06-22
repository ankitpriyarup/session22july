using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
		{
			//GameOver
			SceneManager.LoadScene("Main");
		}
	}
}
