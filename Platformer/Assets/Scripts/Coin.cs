using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float spinSpeed = 100f;
    public int ScoreCount = 0;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0f, Time.deltaTime * this.spinSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Character")
        {
            Destroy(this.gameObject);
            AddScore();
        }  
    }

    void AddScore()
    {
        int Score = ScoreCount++;
        ScoreText.text = ScoreCount.ToString();
    }


}
