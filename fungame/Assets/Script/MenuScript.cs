﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour {


	public void Quitter ()
    {
        Application.Quit();	
	}
	

	public void Jouer ()
    {
        SceneManager.LoadScene (1);
         
	}
}
