using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public static bool goal;
	// Use this for initialization
	void Start () {
        goal = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*Triggerで判定するならこっち*/
    //void OnTriggerEnter(Collider col) {
    //    if (col.gameObject.tag=="Player") {
    //        goal = true;
    //    }

    //    Debug.Log(goal);
    //}

    /*Collisionで判定するならこっち*/
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            goal = true;
        }

        //Debug.Log(goal);
    }

}
