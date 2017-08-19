using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public short Direction = 1;
    public ushort speed = 2;
    public static short dir;
    public Collider2D Laser;
    public bool laser = false;
    public float deathPoint = -5;

    void Start()
    {
        dir = Direction;
    }

    void FixedUpdate ()
    {
        transform.position += new Vector3(dir, 0, 0) * speed * Time.fixedDeltaTime;

		if (dir == 1)
			transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0);
		else
			transform.rotation = Quaternion.Euler (0.0f, 180.0f, 0);
    }

    void Update()
    {
        if (transform.position.y < deathPoint)
            gameObject.SetActive(false);
			//Debug.Log("death");

        if (laser && Laser.gameObject.GetComponent<SpriteRenderer>().enabled)
            gameObject.SetActive(false);
			//Debug.Log("laser");

		Direction = dir;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            laser = true;
            Laser = other;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Laser")
            laser = false;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("qJumps", PlayerPrefs.GetInt("qJumps") + movement.qJumps);
            PlayerPrefs.SetFloat("time", PlayerPrefs.GetFloat("time") + Time.timeSinceLevelLoad);
            PlayerPrefs.SetInt("jumps", PlayerPrefs.GetInt("jumps") + movement.jumps);
            PlayerPrefs.SetFloat("distance", PlayerPrefs.GetFloat("distance") + movement.distance);
            PlayerPrefs.Save();
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
