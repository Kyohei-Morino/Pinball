using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePoz = -6.5f;

    private GameObject gameoverText;

    private GameObject scoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePoz)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 100;

            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }

        if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 30;

            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }

        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;

            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }
    }
}
