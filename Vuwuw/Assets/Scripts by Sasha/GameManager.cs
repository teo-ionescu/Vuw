using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int _bubbleCounter;
    [SerializeField] private GameObject _finalPrizeTrigger;
    [SerializeField] private GameObject _finalPhrase;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseBubbleCounter ()
    {
        _bubbleCounter++;
    }
    public void DecreaseBubbleCounter ()
    {
        _bubbleCounter--;
        if (_bubbleCounter == 0)
        {
            print("AllBubblesCollected");
            _finalPrizeTrigger.SetActive(true);
        }
    }
}
