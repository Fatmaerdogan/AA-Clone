using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PinMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float _UpMoveSpeed;

    public float UpMoveSpeed
    {
        get { return _UpMoveSpeed; }
        set { _UpMoveSpeed = value; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(UpMoveSpeed!=0)rb.MovePosition(rb.position+Vector2.up*_UpMoveSpeed*Time.deltaTime);
    }
}
