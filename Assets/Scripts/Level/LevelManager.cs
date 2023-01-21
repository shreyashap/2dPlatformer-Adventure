using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private static LevelManager _instance;

    public static LevelManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Error");
            }

            return _instance;
        }
    }

 

    public Button[] levelButtons;

    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelReached)
                levelButtons[i].interactable = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
