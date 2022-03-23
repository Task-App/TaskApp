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
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
