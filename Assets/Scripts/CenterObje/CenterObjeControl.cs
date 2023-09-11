using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CenterObjeControl: MonoBehaviour
{
    [SerializeField] private float Speed;
    void Update()
    {
        transform.Rotate(0,0,Speed*Time.deltaTime);
    }
    public void SpeedSet()=> Speed *= -1;

}
