using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points = collectible.points;
        text.text = "Points: " + points.ToString();
    }
}
