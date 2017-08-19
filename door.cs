using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Collider2D coll;
    public bool open = false;
    public string colour = "blue";

    void Update()
    {
		if (open) {
			coll.isTrigger = true;
			GetComponent<SpriteRenderer> ().enabled = false;
            // GetComponent<CanvasGroup>().blocksRaycasts = false;
            gameObject.layer = 2;
		} else {
			coll.isTrigger = false;
			GetComponent<SpriteRenderer> ().enabled = true;
            // GetComponent<CanvasGroup>().blocksRaycasts = true;
            gameObject.layer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            if (colour == "red" && movement.red)
            {
                open = true;
                movement.red = false;
            }

            if (colour == "blue" && movement.blue)
            {
                open = true;
                movement.blue = false;
            }

            if (colour == "green" && movement.green)
            {
                open = true;
                movement.green = false;
            }

            if (colour == "yellow" && movement.yellow)
            {
                open = true;
                movement.yellow = false;
            }
        }
    }
}
