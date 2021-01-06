using UnityEngine;

namespace WebStyleDemo.Scenes {
    public class BootScene : MonoBehaviour {

        private void Start () {
            Debug.Log ("BootScene Start");
        }

        private void OnDestroy () {
            Debug.Log ("BootScene OnDestroy");
        }
    }
}