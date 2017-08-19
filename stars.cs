using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public GameObject star1, star2, star3;
    public ushort minTries;
	void OnEnable ()
    {
        print(atom.quantumJumps + " " + minTries);
        Debug.Log("ello");
        if (atom.quantumJumps <= 3 * minTries)
            star1.SetActive(true);

        if (atom.quantumJumps <= 1.5 * minTries + 1)
            star2.SetActive(true);

        if (atom.quantumJumps <= minTries)
            star3.SetActive(true);
    }

}
