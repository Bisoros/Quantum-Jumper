using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    public GameObject door;
    public Sprite active;
    public Sprite inactive;
    public door Door;
    public AudioSource switchSound;

    void Start()
    {
        Door = door.GetComponent<door>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GetComponent<SpriteRenderer>().sprite == inactive)
            switchSound.Play();
        GetComponent<SpriteRenderer>().sprite = active;
        Door.open = true;

    }

    void OnTriggerStay2D(Collider2D other)
    {
        GetComponent<SpriteRenderer>().sprite = active;
        Door.open = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (GetComponent<SpriteRenderer>().sprite == active)
            switchSound.Play();

        GetComponent<SpriteRenderer>().sprite = inactive;
        Door.open = false;
    }
}
