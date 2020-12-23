using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Game entry point
/// </summary>
public class App : MonoBehaviour
{
   /// <summary>
   /// Keep app alive between scenes
   /// </summary>
   private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /// <summary>
    /// Initializes the app and load the main scene
    /// </summary>
    private void Start()
    {
        InitializeServices();

        SceneManager.LoadScene("MainScene");
    }

    private void OnDestroy()
    {
        DisposeServices();
    }

    /// <summary>
    /// Initializes all services
    /// </summary>
    private void InitializeServices() {
        Debug.Log("InitializeServices");

        JsonService.Instance.Initialize();
        HttpService.Instance.Initialize();
        GameDataService.Instance.Initialize();
    }

    /// <summary>
    ///  Dispose all services
    /// </summary>
    private void DisposeServices() {
        Debug.Log("DisposeServices");

        JsonService.Instance.Dispose();
        HttpService.Instance.Dispose();
        GameDataService.Instance.Dispose();
    }
}
