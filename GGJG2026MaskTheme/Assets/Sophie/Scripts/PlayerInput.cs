using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject melee1;
    [SerializeField] Transform instanpoint;

    private void Awake()
    {
        instanpoint = GameObject.Find("melee1").transform;
    }

    void Shoot()
    {
    melee1 = Instantiate(melee1, instanpoint.position, instanpoint.rotation);
        //melee1.transform.position = Mathf.Lerp();
    }
}
