using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterObjeCollider : MonoBehaviour
{
    CenterObjeControl centerObjeControl;
    private void Start()
    {
        centerObjeControl = GetComponent<CenterObjeControl>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            collision.transform.GetComponent<PinCollider>().CenterObjeCollision();
            ColliderObjeParentSet(collision.transform);
            centerObjeControl.SpeedSet();
        }
     
    }
    public void ColliderObjeParentSet(Transform transform)
    {
        transform.SetParent(this.transform);
    }
}
