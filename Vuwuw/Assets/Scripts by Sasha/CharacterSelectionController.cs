using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionController : MonoBehaviour
{
    [SerializeField] private GameObject[] _charactersArray;
    [SerializeField] int _currentCharacter;

    public void CharacterSelectionLeft()
    {
        for (int i = 0; i <= _charactersArray.Length - 1; i++)
        {
            _charactersArray[i].SetActive(false);
        }
        if (_currentCharacter == 0)
        {
            _currentCharacter = _charactersArray.Length-1;
           
        }
        else
        {
            _currentCharacter--;
        }
        _charactersArray[_currentCharacter].SetActive(true);
        //Deactivate all and activate only one that you need
    }
    public void CharacterSelectionRight()
    {
        for (int i = 0; i <= _charactersArray.Length - 1; i++)
        {
            _charactersArray[i].SetActive(false);
        }
        if (_currentCharacter == _charactersArray.Length - 1)
        {
            _currentCharacter = 0;

        }
        else
        {
            _currentCharacter++;
        }
        _charactersArray[_currentCharacter].SetActive(true);
    }

    public void CharacterSelectionConfirmed()
    {
        PlayerPrefs.SetInt("Character selected", _currentCharacter);
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
