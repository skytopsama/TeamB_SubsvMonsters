﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 100f;
	public float currentHealth;

	public Font myFont;

	void Awake ()
	{
		currentHealth = startingHealth;
	}

	void OnGUI ()
	{
		GUI.color = Color.white;
		GUIStyle myStyle = new GUIStyle ();
		myStyle.font = myFont;
		GUI.Label (new Rect (20, 20, 100, 50), "" + currentHealth, myStyle);
	}
}