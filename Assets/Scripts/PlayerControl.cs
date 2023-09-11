using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    SpawnControl spawnControl;
    private void Start()
    {
        spawnControl = GetComponent<SpawnControl>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) StartCoroutine(spawnControl.Spawn());
    }
}
