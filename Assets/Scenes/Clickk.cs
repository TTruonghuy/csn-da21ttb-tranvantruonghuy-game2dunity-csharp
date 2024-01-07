using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Clickk : MonoBehaviour
{
    
    public void Playy()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
