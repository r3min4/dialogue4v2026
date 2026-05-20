using UnityEngine;

namespace Core
{
    public class BootLoader : MonoBehaviour
    {
        public string nextScene = "SampleScene";

        public void LoadNextScene()
        {
            GameManager.Instance.StartGame();
            Debug.Log($"BootLoader: Loaded scene '{nextScene}'");
        }

        public void Quit()
        {
            GameManager.Instance.Quit();
        }
    }
}