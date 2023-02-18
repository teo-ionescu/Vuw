using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScores : MonoBehaviour
{
    [SerializeField] private int[] _scoreBubble;
    [SerializeField] int _randomScore;
    [SerializeField] ScoreManager _scoreManager;
    [SerializeField] GameManager _gameManager;
    // Start is called before the first frame update
    private void Start()
    {
        _randomScore = Random.RandomRange(0, 10);
        _gameManager.IncreaseBubbleCounter();
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Destroy(gameObject);
        _scoreManager.IncreaseScore(_randomScore);
        _gameManager.DecreaseBubbleCounter();
        //Destroy(other.gameObject);
    }
}





    /*[SerializeField] private int[] _scoreBubble;
    //[SerializeField] int _randomScore;
    [SerializeField] ScoreManager _scoreManager;
    [SerializeField] public int _randomScore;
    // Start is called before the first frame update
    private void Start()
    {
        //Randomize random score here
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        //_randomScore = Random.Range(0, 1000);
        _scoreManager.IncreaseScore(Random.Range(0, 1000));
        //Destroy(other.gameObject);
        Destroy(gameObject);
    }*/
