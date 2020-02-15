using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreCount;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Coin") return;
        {
            AddScore();
        }
        
    }

    void AddScore()
    {
        ScoreCount++;
        ScoreText.text = ScoreCount.ToString();
    }
}
