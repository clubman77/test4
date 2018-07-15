using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float time;
    //[SerializeField] private float test;

    // Use this for initialization
    void Start()
    {
        time = 300;
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.goal == false && time>1)
        {
            //time += Time.deltaTime * 0.5f;
            time -= Time.deltaTime;
        }
        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "のこりじかん:" + t+" びょう";
    }
}
