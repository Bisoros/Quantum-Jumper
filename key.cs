using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public string colour = "blue";
    public GameObject card;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
           GameObject a = Instantiate(card, other.transform);
            a.SetActive(true);
            print("huh");
            if (colour == "red")
                movement.red = true;

            if (colour == "blue")
                movement.blue = true;

            if (colour == "green")
                movement.green = true;

            if (colour == "yellow")
                movement.yellow = true;

            gameObject.SetActive(false);
        }
    }
}
