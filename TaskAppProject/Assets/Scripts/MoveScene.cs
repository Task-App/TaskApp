using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SplashChange()); 
    }

    IEnumerator SplashChange()
    {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

        //while (!asyncLoad.isDone)
        //{
        //    yield return null;
        //}

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(1);
    }
}
