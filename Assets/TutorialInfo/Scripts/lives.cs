using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class lives : MonoBehaviour
{
    public TextMeshPro text;
    public destroyable destr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<destroyable>();
        text.text = destr.lives + "/5";
    }
}
