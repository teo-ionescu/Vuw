using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereBehavior : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    // Start is called before the first frame update
    void Update()
    {
        scoreText.GetComponent<Text>().text = "LOVE: " + theScore;
    }
}
