using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    // SCENE REFERENCES HERE: attached from Unity Editor
    [SerializeField] protected Button goToMenuButton;

    /// <summary>
    /// Adds events
    /// </summary>
    private void Start()
    {
        Debug.Log("MainScene Start");

        goToMenuButton.onClick.AddListener(OnGoToMenuButtonClicked);
    }

    /// <summary>
    /// Removes listeners
    /// </summary>
    private void OnDestroy()
    {
        Debug.Log("MainScene OnDestroy");

        goToMenuButton.onClick.RemoveListener(OnGoToMenuButtonClicked);        
    }

    private void OnGoToMenuButtonClicked() {
        SceneManager.LoadScene("MenuScene");
    }
}
