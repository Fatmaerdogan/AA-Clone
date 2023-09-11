using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollider : MonoBehaviour
{
    PinControl PinControl;
    PinMovement PinMovement;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PinControl = GetComponent<PinControl>();
        PinMovement = GetComponent<PinMovement>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            GameManager.instance.GameEndActive(false);
        }

    }
    public void CenterObjeCollision()
    {
        PinMovement.UpMoveSpeed = 0;
        PinControl.PinPointActive=true;
    }
}
