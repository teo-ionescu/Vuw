using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Debug.Log("Trigger");
        SphereBehavior.theScore += 90;
        Destroy(gameObject);
    }
}
