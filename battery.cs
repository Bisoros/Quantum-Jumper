using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour
{
    public ushort capacity = 5;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            if (movement.quantumTries < movement.maxQuantumTries)
                if (movement.quantumTries + capacity <= movement.maxQuantumTries)
                    movement.quantumTries += capacity;
                else
                    movement.quantumTries = movement.maxQuantumTries;
            
            gameObject.SetActive(false);
        }
    }
}
