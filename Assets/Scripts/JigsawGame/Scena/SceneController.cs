using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    
    [SerializeField]
    private List<string> sceneNames = new List<string>();

    public void LoadSceneByName()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadRandomScene()
    {
        if (sceneNames.Count > 0)
        {
            int randomIndex = Random.Range(0, sceneNames.Count);
            string randomSceneName = sceneNames[randomIndex];
            SceneManager.LoadScene(randomSceneName);
        }
        else
        {
            Debug.LogWarning("No scenes in the list to load.");
        }
    }
}