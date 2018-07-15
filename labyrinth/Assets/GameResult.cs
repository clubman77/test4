using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{

    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;
    public GameObject timeoverUI;
    bool flg = true;

    // Use this for initialization
    void Start()
    {
        //最高記録の初期化
        //PlayerPrefs.DeleteKey("HighScore");

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.time <= 1)
        {
            //if (flg == true) {
            //    Debug.Log("Time Over");
            //    Debug.Log(flg);
            //    flg = false;
            //}
            timeoverUI.SetActive(true);
        }
        else {
            if (Goal.goal)
            {

                resultUI.SetActive(true);
                int result = Mathf.FloorToInt(Timer.time);
                resultTime.text = "けっか:" + result;
                bestTime.text = "さいこうきろく:" + highScore;

                if (highScore < result)
                {
                    PlayerPrefs.SetInt("HighScore", result);
                }
            }
        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
    }
}
