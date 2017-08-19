using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour {


	IEnumerator next()
	{
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene (10);
	}
	void Start () {
		DontDestroyOnLoad (gameObject);
		StartCoroutine (next ());
	}

}
