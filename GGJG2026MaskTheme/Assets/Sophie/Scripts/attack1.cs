using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack1 : MonoBehaviour
{
    eventmanager eventmanager;

    private void Awake()
    {
        eventmanager = GameObject.Find("EventManager").GetComponent<eventmanager>();
    }
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Enemy")
        {
            EnemyScript target = hit.gameObject.GetComponent<EnemyScript>();
            eventmanager.damageHit(target, 30);
            Destroy(gameObject);
        }
    }
}
