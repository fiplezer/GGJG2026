using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public EventSystem eventSystem;

    private bool isActive = false;
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        eventSystem.gameObject.SetActive(false);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

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

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }
}
