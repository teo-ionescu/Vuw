using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour
{
    public void PushOne()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void PushTwo()
    {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
    public void PushThree()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
