using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    [SerializeField] public string sceneName;
    public void PlayGame() 
    {
        SceneManager.LoadScene(sceneName);
    }
}
