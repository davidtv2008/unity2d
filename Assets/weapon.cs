﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject flarePrefab;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			shoot();

		}

	}

	void shoot()
	{
		//shooting logic
		Instantiate(flarePrefab,firePoint.position,firePoint.rotation);

	}
}
