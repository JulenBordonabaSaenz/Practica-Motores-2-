﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerComida : MonoBehaviour {
    bool eatable;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(transform.tag=="comida"&& Input.GetButtonDown("Fire1") && eatable==true)
        {
            eatable = false;
            //Destroy(comida)
        }
    }
}
