using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void Strt()
    {
        GameObject spawner = GameObject.FindWithTag("Spawner");
        LixoSpawnerController script = spawner.GetComponent<LixoSpawnerController>();
        script.StartGame();
        // spawner.gameObject.StartGame();
    }
}
