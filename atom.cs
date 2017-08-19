using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class atom : MonoBehaviour 
{
	public GameObject end, canvas;
	public Text time, qJumps;
    public AudioSource win;
    public static int quantumJumps;

    IEnumerator End()
    {
        yield return new WaitForSeconds(.5f);
        Time.timeScale = 0;
        canvas.SetActive(false);
        end.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Player")
		{
			
			int aux = (int)((Time.timeSinceLevelLoad - (int)Time.timeSinceLevelLoad)*100);
			time.text = "Elapsed Time: " + ((int)Time.timeSinceLevelLoad).ToString()+","+ aux.ToString();
            quantumJumps = movement.qJumps;
			qJumps.text = "Quantum Jumps Count: "+ quantumJumps.ToString();
            win.Play();
            StartCoroutine(End());

            PlayerPrefs.SetInt("qJumps", PlayerPrefs.GetInt("qJumps") + quantumJumps);
            PlayerPrefs.SetFloat("time", PlayerPrefs.GetFloat("time") + Time.timeSinceLevelLoad);
            PlayerPrefs.SetInt("jumps", PlayerPrefs.GetInt("jumps") + movement.jumps);
            PlayerPrefs.SetFloat("distance", PlayerPrefs.GetFloat("distance") + movement.distance);
            if (PlayerPrefs.GetInt("lastLevel", 1) <= SceneManager.GetActiveScene().buildIndex)
                PlayerPrefs.SetInt("lastLevel", PlayerPrefs.GetInt("lastLevel", 1) + 1);
            PlayerPrefs.Save();
		}
    }
}
