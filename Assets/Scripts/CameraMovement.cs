using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public Transform player;
    public Movemnet playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = player.GetComponent<Movemnet>();
    }
    float yaw;
    float pitch;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        yaw += rotationSpeed * Input.GetAxis("Mouse X");
        pitch -= rotationSpeed * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -20, 30);

        playerMovement.SetRotation(yaw);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
