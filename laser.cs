using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float coolDown=1;
    public float startTime=.5f;

    IEnumerator Laser()
    {
        yield return new WaitForSeconds(startTime);

        while (coolDown>0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(coolDown);

            GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(coolDown);            
        }
    }

	void Start ()
    {
        StartCoroutine (Laser());
	}
}
