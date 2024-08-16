using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public static TutorialManager Instance { get; private set; }
    private bool isTutorialActive = true;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {       
        Time.timeScale = 0f;
    }

    public void CloseTutorial()
    {
        
        isTutorialActive = false;
        Time.timeScale = 1f;
    }

    public bool IsTutorialActive()
    {
        return isTutorialActive;
    }
}
