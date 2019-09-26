using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;


    // Start is called before the first frame update
    void Start()
    {
       playButton.onClick.AddListener(GameManager.Instance.ResumeGame);
       quitButton.onClick.AddListener(Application.Quit);
    }
}
