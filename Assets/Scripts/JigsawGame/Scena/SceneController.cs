using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    public void SceneLoad()
    {
        SceneManager.LoadScene(sceneName);
    }
}