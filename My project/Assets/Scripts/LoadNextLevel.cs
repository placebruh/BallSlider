using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private int nextSceneToLoad;
    private void Start()
    {
        
    nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneToLoad);
            gameObject.SetActive(false);

        }
        
    }

}
