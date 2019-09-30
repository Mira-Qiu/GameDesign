using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalPageReport : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int newscore = finalTotalController.totalScore;
        score.text = newscore.ToString();
    }
}
