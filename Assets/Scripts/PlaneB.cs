using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class PlaneB : Enemy
    {
        public Renderer m_renderer;
        Material m_material;
        public float m_speed = 20.0f;
        public float m_waitTime = 2.0f;
        bool m_isReady = false;

        void Start()
        {
            HP = 20;

            m_material = m_renderer.material;
            gameObject.GetComponent<Collider>().enabled = false;
            float angle = Random.Range(-45.0f, 45.0f);
            transform.Rotate(0, 0, angle);
            StartCoroutine(AppearStart());
        }

        IEnumerator AppearStart()
        {
            float elapsedTime = 0;
            float alpha = 0;
            Color materialColor = m_material.color;
            Color newColor = new Color(materialColor.r, materialColor.g, materialColor.b, 0);
            m_material.color = newColor;

            while (elapsedTime < m_waitTime)
            {
                alpha += Time.deltaTime / m_waitTime;
                newColor = new Color(materialColor.r, materialColor.g, materialColor.b, alpha);
                m_material.color = newColor;
                yield return null;
                elapsedTime += Time.deltaTime;
            }
            gameObject.GetComponent<Collider>().enabled = true;
            m_isReady = true;
        }

        public override void GetHit(int damage)
        {
            transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            base.GetHit(damage);
        }

        void Update()
        {
            if (m_isReady)
            {
                transform.Translate(Vector3.down * Time.deltaTime * m_speed);
            }
        }

        private void OnEnable()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerController playerControl = playerObject.GetComponent<PlayerController>();
            playerControl.m_bombAction += BombActionPlaneB;
        }

        private void OnDisable()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerController playerControl = playerObject.GetComponent<PlayerController>();
            playerControl.m_bombAction -= BombActionPlaneB;
        }

        void BombActionPlaneB()
        {
            if (m_isReady)
            {
                GetHit(100000);
            }
        }
    }

}
