using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public EventSystem eventSystem;

    private bool isActive = false;

    void Start()
    {
        eventSystem.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isActive = !isActive;
            eventSystem.gameObject.SetActive(isActive);

            if (!isActive)
            {
                eventSystem.SetSelectedGameObject(null);
            }
        }
    }
}
