using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float distance = 10f;
    [SerializeField]
    private float height = 5.0f;
    [SerializeField]
    private float heightDamping = 2.0f;
    private Transform player;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        float wantedHeight = player.position.y + height;

        float currentHeight = transform.position.y;

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        transform.position = player.position;
        transform.position -= Vector3.forward * distance;

        transform.position= new Vector3(transform.position.x, currentHeight, transform.position.z);

        transform.LookAt(player);
    }
}
