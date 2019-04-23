using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel2 : MonoBehaviour {

    [SerializeField] private string loadLevel;

    void OnTriggerEnter2D(Collider2D col)
    { // Find type of collider, then begin 
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(loadLevel);
        }
    }
}
