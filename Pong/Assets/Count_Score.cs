using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour {

    public Text Scoreboard;
    public GameObject ball;


    public static bool canAddScore = true;

    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {

        if (ball.transform.position.x >= 20f && canAddScore)
        {
            canAddScore = false;
            Bat_1_Score++;
        }
        if (ball.transform.position.x <= -20f && canAddScore)
        {
            canAddScore = false;
            Bat_2_Score++;
        }

        if(Bat_1_Score >= 7)
        {
            SceneManager.LoadScene(2);
        }
        if(Bat_2_Score >= 7)
        {
            SceneManager.LoadScene(3);
        }

        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString();

        print(Bat_1_Score + " , " + Bat_2_Score);
	}
}
