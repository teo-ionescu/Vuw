using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPrize : MonoBehaviour
{
    [SerializeField] private GameObject _finalPrize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _finalPrize.SetActive(true);
    }
}
