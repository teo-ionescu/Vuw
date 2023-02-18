using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text _scoreText;

    int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = _score.ToString() + "LOVE";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void IncreaseScore (int newScore)
    {
        _score += newScore;
        _scoreText.text = _score.ToString() + "LOVE";
    }
}
