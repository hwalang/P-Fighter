using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float m_mouseSensitivity = 100.0f;
    public GameObject m_player;
    float m_xRotate = 0.0f;

    private void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * m_mouseSensitivity * Time.deltaTime;

        // 고개를 위아래로 움직임
        m_xRotate -= mouseY;
        m_xRotate = Mathf.Clamp(m_xRotate, -90.0f, 90.0f);
        transform.localRotation = Quaternion.Euler(m_xRotate, 0.0f, 0.0f);

        // 고개를 좌우로 움직임
        m_player.transform.Rotate(Vector3.up, mouseX);
    }
}
