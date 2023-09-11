using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Color WinColor;
    [SerializeField] private Color FailColor;

    Camera mainCamera;

    public  Action<bool> GameEndActive;

    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        mainCamera = Camera.main;
        GameEndActive += ColorSet;
    }

    public void ColorSet(bool temp)
    {
        mainCamera.backgroundColor=(temp ? WinColor : FailColor);
    }
}
