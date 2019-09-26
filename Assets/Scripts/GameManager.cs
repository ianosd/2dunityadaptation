using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance {get; private set;}

    public MenuController menuController;

    void Awake()
    {
        if (Instance != null){
            Debug.LogError("GameManager instance is being overriden");
        }
        Instance = this;
    }

    void Start()
    {
        PauseGame();
    }

    void Update()
    {
        HandleInput();
    }

    public void PauseGame(){
        Time.timeScale = 0;
        SetMenuVisible(true);
    }

    public void ResumeGame(){
        Time.timeScale = 1;
        SetMenuVisible(false);
    }

    private void SetMenuVisible(bool visible){
        menuController.gameObject.SetActive(visible);
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
}
