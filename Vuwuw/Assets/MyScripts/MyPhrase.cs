using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPhrase : MonoBehaviour
{
    public GameObject UiObject;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
    }
}
