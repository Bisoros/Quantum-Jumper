using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quantumtries : MonoBehaviour {

    public Text quantumTries;

	void Update ()
    {
        quantumTries.text = movement.quantumTries.ToString();
	}
}
