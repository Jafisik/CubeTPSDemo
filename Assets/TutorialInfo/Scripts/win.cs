using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class win : MonoBehaviour
{
    public TextMeshProUGUI text;
    bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collectible.points == 10 && finished == false)
        {
            StartCoroutine(waiter());
            finished = true;
        }
    }

    IEnumerator waiter()
    {
        text.text = "You win";
        yield return new WaitForSeconds(5);
        text.text = "";
    }
}
