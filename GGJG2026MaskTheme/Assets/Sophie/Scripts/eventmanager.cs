using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class eventmanager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] PlayerInfo Playerstats;
    [SerializeField] GameObject currentEnemy;
    [SerializeField] GameObject melee1;
    [SerializeField] GameObject melee2;
    [SerializeField] GameObject ranged1;
    [SerializeField] GameObject ranged2;
    [SerializeField] bool hitprocces = false;

    void Awake()
    {
        Player = GameObject.Find("Player");
        Playerstats = GameObject.Find("Player").GetComponent<PlayerInfo>();
        melee1 = GameObject.Find("melee1");
        melee2 = GameObject.Find("melee2");
        ranged1 = GameObject.Find("ranged1");
        ranged2 = GameObject.Find("ranged2");
    }


    public void damageHit(EnemyScript creature, int dmg)
    {
        hitprocces = true;
        if (creature.hp - dmg > 0 && hitprocces == true)
        {
            die();
            hitprocces = false;
        }
        creature.hp -= dmg;
        hitprocces = false;
    }

    void die()
    {
        Destroy(Playerstats.gameObject);
    }
}
