using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public GameObject door;
    public bool Open = false;
    public Sprite active;
    public door Door;
    public AudioSource switchSound;

    void Start()
    {
        Door = door.GetComponent<door>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&&!Open)
        {
            Open = true;
            switchSound.Play();
            SpriteRenderer aux = GetComponent<SpriteRenderer>();
            aux.sprite = active;
			Door.open = true;
        }
    }
}
