using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour
{

    //　メインカメラ
    [SerializeField] private  GameObject mainCamera;      
     //public static GameObject mainCamera;
    //　切り替える他のカメラ
    [SerializeField] private  GameObject otherCamera;
    // public static  GameObject otherCamera;


    void Start() {
        //  Debug.Log("ChangeCamera_Start");
    }

    // Update is called once per frame
    void Update()
    {
        //　1キーを押したらカメラの切り替えをする
        if (Input.GetKeyDown("1"))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            otherCamera.SetActive(!otherCamera.activeSelf);
        }
    }

}