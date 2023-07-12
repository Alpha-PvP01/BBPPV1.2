using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IIEnemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    Vector2 baseCord;
    public float distanceBetween;
    private float distance;
    void Start()
    {
        baseCord = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        cheiseHero();
        goBack();
    }
    private void cheiseHero()
    {
        if (distance < distanceBetween)
        {
            if (transform.position.x < player.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            }
        }
    }
    private void goBack() 
    {
        if (distance > distanceBetween)
        {
            if (transform.position.x < baseCord.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                transform.position = Vector2.MoveTowards(this.transform.position, baseCord, speed * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = Vector2.MoveTowards(this.transform.position, baseCord, speed * Time.deltaTime);
            }
        }
    }
}


