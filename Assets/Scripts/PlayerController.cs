using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class PlayerController : MonoBehaviour
    {
        // public int m_repeatFireCnt = 5;
        public float m_fireInterval = 0.5f;
        public bool m_isFiring = false;
        IEnumerator m_fireCoroutine;

        public GameObject m_planeObject;
        public GameObject m_missilePrefab;
        public Transform[] m_spawnArray;

        // 발사 주기 1초
        public float m_interval = 1.0f;
        public float m_nextFireTime;
        private float m_speed = 50.0f;

        private float m_rotationSpeed = 100.0f;
        public float m_yAngles = 0;

        public GameObject m_bombPrefab;
        public delegate void BombAction();
        public BombAction m_bombAction;

        void Start()
        {
            m_nextFireTime = Time.time + m_interval;
        }

        void Update()
        {
            Vector3 curPos = transform.position;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Left");
                curPos.x = curPos.x + Input.GetAxis("Horizontal") * Time.deltaTime * m_speed;

                if (m_yAngles < 45)
                {
                    m_yAngles += m_rotationSpeed * Time.deltaTime;
                    m_planeObject.transform.rotation = Quaternion.Euler(180, m_yAngles, 0);
                }
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Right");
                curPos.x = curPos.x + Input.GetAxis("Horizontal") * Time.deltaTime * m_speed;

                if (m_yAngles > -45)
                {
                    m_yAngles -= m_rotationSpeed * Time.deltaTime;
                    m_planeObject.transform.rotation = Quaternion.Euler(180, m_yAngles, 0);
                }
            }
            else
            {
                // + 를 0으로 이동
                if (m_yAngles > 0)
                {
                    m_yAngles -= m_rotationSpeed * Time.deltaTime;
                    if (m_yAngles < 0)
                    {
                        m_yAngles = 0;
                    }
                }
                // - 를 0으로 이동
                else if (m_yAngles < 0)
                {
                    m_yAngles += m_rotationSpeed * Time.deltaTime;
                    if (m_yAngles > 0)
                    {
                        m_yAngles = 0;
                    }
                }
                m_planeObject.transform.rotation = Quaternion.Euler(180, m_yAngles, 0);
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("Up");
                curPos.y = curPos.y + Input.GetAxis("Vertical") * Time.deltaTime * m_speed;
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("Down");
                curPos.y = curPos.y + Input.GetAxis("Vertical") * Time.deltaTime * m_speed;
            }
            transform.position = curPos;

            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                if (!m_isFiring)
                {
                    m_fireCoroutine = FireMissile();
                    StartCoroutine(m_fireCoroutine);
                }
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                if (m_isFiring)
                {
                    StopCoroutine(m_fireCoroutine);
                    m_isFiring = false;
                }    
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                FireBomb();
                if (m_bombAction != null)
                {
                    m_bombAction();
                }
            }
        }

        void FireBomb()
        {
            for (int i = 0; i < 15; ++i)
            {
                float xPos = Random.Range(-20.0f, 20.0f);
                float yPos = Random.Range(-20.0f, 20.0f);
                Vector3 pos = new Vector3(xPos, yPos, 0f);

                GameObject bomb = (GameObject)Instantiate(m_bombPrefab, pos, Quaternion.identity);
                Destroy(bomb, 0.5f);
            }
        }

        IEnumerator FireMissile()
        {
            m_isFiring = true;
            while (true)
            {
                foreach (Transform trans in m_spawnArray)
                {
                    Quaternion q = trans.rotation;
                    GameObject missile = (GameObject)Instantiate(m_missilePrefab, trans.position, q);
                    Destroy(missile, 5.0f);
                }
                yield return new WaitForSeconds(m_fireInterval);
            }
        }
    }

}


