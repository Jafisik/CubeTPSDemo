using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.UnloadScene(1);
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
            collectible.points = 0;
        }
    }
}
