using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreHP : MonoBehaviour
{
    private Health healthThis;
    public string collisionTag;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == collisionTag && Input.GetKey(KeyCode.F))
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.SetHealth(50);
        }
    }
}
