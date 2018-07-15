using UnityEngine;
using System.Collections;

public class ChangeCamera2 : MonoBehaviour
{

    //　メインカメラ
    [SerializeField] private  GameObject mainCamera;      
     //public static GameObject mainCamera;
    //　切り替える他のカメラ
    [SerializeField] private  GameObject otherCamera;
    // public static  GameObject otherCamera;
    bool flg = true;


    void Start() {
        //  Debug.Log("ChangeCamera_Start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer.time <= 1 || Goal.goal)
        {
            if (flg == true) {
                mainCamera.SetActive(!mainCamera.activeSelf);
                otherCamera.SetActive(!otherCamera.activeSelf);
                Debug.Log("ChangeCamera2");
                flg = false;
            }
            

        }
    }

}