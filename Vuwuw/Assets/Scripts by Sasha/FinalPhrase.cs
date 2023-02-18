using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPhrase : MonoBehaviour
{
    [SerializeField] private int[] _myPhrases;
    [SerializeField] private int[] _myPhrasesArray;
    [SerializeField] int _random;
    [SerializeField] FinalPrize finalPrize;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        _random = Random.Range(0, _myPhrasesArray.Length);
    }
}
//