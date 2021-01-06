using UnityEngine;
using UnityEngine.SceneManagement;

namespace WebStyleDemo.Scenes {
    public class MenuScene : MonoBehaviour {

        private void Start () {
            Debug.Log ("MenuScene Start");
        }

        private void OnDestroy () {
            Debug.Log ("MenuScene OnDestroy");
        }

        private void Update () {
            if (Input.GetKeyUp (KeyCode.Escape)) {
                SceneManager.LoadScene ("MainScene");
            }
        }
    }
}