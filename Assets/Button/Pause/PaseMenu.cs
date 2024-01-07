using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenu;
    public void Pause()
    {
        PauseMenu.SetActive(true); // hiển thị PauseMenu
        Time.timeScale = 0; //dừng game
        
    }
    public void Resume()
    {
        PauseMenu.SetActive(false); // ẩn PauseMenu
        Time.timeScale = 1; // tiếp tục game 
    }
    public void Exit()
    {
        Application.Quit(); // thoát game
    }
}
