﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void SelectLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
