using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;
    private GameObject scoreCounter;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreCounter = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        this.scoreCounter.GetComponent<Text>().text = score.ToString();
    
    }

    void OnCollisionEnter(Collision item)
    {
        if (item.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (item.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }
        else if (item.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.score += 30;
        }
        
    }
}
