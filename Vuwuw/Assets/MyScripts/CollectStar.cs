using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Debug.Log("Trigger");
        SphereBehavior.theScore += 50;
        Destroy(gameObject);
    }
}
