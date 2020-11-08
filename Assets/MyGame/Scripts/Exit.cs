using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Exit : MonoBehaviour
{   
    public void QuitGame()
    {
        EditorSceneManager.LoadScene(1);
    }
}
