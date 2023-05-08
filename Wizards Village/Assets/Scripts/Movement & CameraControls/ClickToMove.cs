using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    [SerializeField]
    private InputAction mouseClickAction;

    private Camera mainCamera;
    private NavMeshAgent nav;
    private void Awake()
    {
        mainCamera = Camera.main;
        nav = this.GetComponent<NavMeshAgent>();
        nav.speed = movespeed;
    }

    private void OnEnable()
    {
        mouseClickAction.Enable();
        mouseClickAction.performed += Move;
    }

    private void OnDisable()
    {
        mouseClickAction.performed -= Move;
        mouseClickAction.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if(Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider)
        {
            nav.SetDestination(hit.point);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if(nav != null)
            Gizmos.DrawSphere(nav.destination, 0.2f);
    }
}
