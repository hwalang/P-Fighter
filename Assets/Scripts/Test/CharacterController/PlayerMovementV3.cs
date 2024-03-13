using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementV3 : MonoBehaviour
{
    public CharacterController m_playerController;
    public float m_speed = 10.0f;

    public Transform m_groundCheck;
    public float m_radius = 0.04f;
    public LayerMask m_groundMask;
    public float m_jumpHeight = 5.0f;

    bool m_isGrounded;
    Vector3 m_gravityMovement;
    Vector3 m_velocity;

    public float m_orgStepOffset;
    public float m_orgSlopeLimit;

    private void Start()
    {
        m_orgStepOffset = m_playerController.stepOffset;
        m_orgSlopeLimit = m_playerController.slopeLimit;
    }

    void Update()
    {
        //m_isGrounded = Physics.CheckSphere(m_groundCheck.position, m_radius, m_groundMask);
        m_isGrounded = m_playerController.isGrounded;

        if (!m_isGrounded)
        {
            m_playerController.stepOffset = 0f;
            m_playerController.slopeLimit = 0f;
        }
        else
        {
            m_playerController.stepOffset = m_orgStepOffset;
            m_playerController.slopeLimit = m_orgSlopeLimit;
        }

        if (m_isGrounded && m_velocity.y < 0)
        {
            m_velocity.y = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && m_isGrounded)
        {
            m_velocity.y = Mathf.Sqrt(2.0f * 9.8f * m_jumpHeight);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveAmount = transform.right * x + transform.forward * z;

        float magnitude = moveAmount.magnitude;
        magnitude = Mathf.Clamp01(magnitude);

        moveAmount.Normalize();
        m_playerController.Move(moveAmount * m_speed * Time.deltaTime);

        m_velocity.y += -9.8f * Time.deltaTime;     // 9.8f: 중력 가속도
        m_gravityMovement.y = m_velocity.y * Time.deltaTime;
        m_playerController.Move(m_gravityMovement);
    }
}
