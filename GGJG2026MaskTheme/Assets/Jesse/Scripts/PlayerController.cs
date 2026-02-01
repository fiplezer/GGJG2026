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

    //Zoe code animator//
    private Animator animatorMask;

    private const string _horizontal = "Horizontal";
    private const string _vertical = "Vertical";
    // einde //
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorMask = GetComponentInChildren<Animator>();
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

        animatorMask.SetFloat(_horizontal, movement.x);
        animatorMask.SetFloat (_vertical, movement.y);
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }
}
