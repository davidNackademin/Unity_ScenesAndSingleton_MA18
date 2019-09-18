using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    AsyncOperation async;

    private void Start()
    {
        Player.Instance.transform.position = Vector3.zero;

        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Scene1")
        {
            async = SceneManager.LoadSceneAsync("Scene2");
            async.allowSceneActivation = false;


        }
        else if (scene.name == "Scene2")
        {
            async = SceneManager.LoadSceneAsync("Scene1");
            async.allowSceneActivation = false;
        }



    }

    private void OnMouseDown()
    {

        if (async != null)
        {
            async.allowSceneActivation = true;
        }

        
    }



}
