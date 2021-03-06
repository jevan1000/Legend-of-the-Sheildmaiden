﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Level : MonoBehaviour
{

    public string scene_to_load;
    public string scene_to_unload;
    public Rigidbody player;

    public void Update()
    {
        //player = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    [HideInInspector]
    public bool unloaded = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadSceneAsync(scene_to_load, LoadSceneMode.Additive);
        }
        else
        {
            return;
        }
        if (!unloaded)
        {
            unloaded = true;

            AnyManager.anyManager.UnloadScene(scene_to_unload);
        }
    }
}
