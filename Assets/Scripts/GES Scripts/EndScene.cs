﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("return"))
            SceneManager.LoadScene("StartMenu");
    }
    
}
