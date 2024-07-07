using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.UnloadScene(0);
        SceneManager.LoadScene(1);
    }
}
