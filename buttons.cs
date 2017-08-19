using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
	public GameObject overlay, canvas;
    public static bool tp = false;

    public void Tp()
    {
        if (Time.timeScale != 0)
            tp = true;
    }

    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void pause()
    {
		canvas.SetActive (false);
		overlay.SetActive (true);

		Time.timeScale = 0;
    }

	public void resume()
	{
		canvas.SetActive (true);
		overlay.SetActive (false);

		Time.timeScale = 1;
	}

	public void next()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
