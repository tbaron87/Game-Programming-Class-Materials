using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapExample : MonoBehaviour
{
    [SerializeField]
    private Scene scene;

    private AsyncOperation loading;

    public void Start()
    {
        loading = SceneManager.LoadSceneAsync(scene.buildIndex);
    }

    public void Update()
    {
        if (loading.isDone)
        {
            if (!SceneManager.SetActiveScene(scene))
            {
                Debug.LogError("Loading the Scene Failed!!");
            }
        }
    }
}
