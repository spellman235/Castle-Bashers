﻿using UnityEngine;
using System.Collections;

public class EndOfLevelTrigger : MonoBehaviour {

    private Main_Process mainprocess;

    void Start()
    {
        mainprocess = FindObjectOfType<Main_Process>();
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            mainprocess.UI_Mission_Success_Open();
        }
    }

    void Update()
    {
 
    }
}
