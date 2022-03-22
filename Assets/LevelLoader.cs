using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadTime = 3f;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScreen());
        }
        
        
    }

    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(loadTime);
        LoadNextScene();

    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Single);
    }
}
