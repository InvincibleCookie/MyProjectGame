using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private string scene;
    public void SetLevel()
    {
        SceneManager.LoadScene(scene);
    }
}
