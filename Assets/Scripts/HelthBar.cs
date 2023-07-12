using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{
    public Image bar;
    public float fill;
    public int collisionDamage;
    public string collisionTag;
    private Health healthThis;
    void Start()
    {
        fill = 1f;
        healthThis = GetComponent<Health>();
        healthThis.onChanged += Uphp;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }
 
    private void Uphp(int hp)
    {
        bar.fillAmount = (float)healthThis.health / healthThis.maxHealth;
    }

    private void OnDestroy()
    {
        healthThis.onChanged -= Uphp;
    }
}
