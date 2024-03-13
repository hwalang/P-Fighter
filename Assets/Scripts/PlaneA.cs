using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class PlaneA : Enemy
    {
        public float m_speed = 10.0f;

        private void Update()
        {
            transform.Translate(Vector3.down * Time.deltaTime * m_speed);
        }

        private void OnEnable()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerController playerControl = playerObject.GetComponent<PlayerController>();
            playerControl.m_bombAction += BombActionPlaneA;
        }

        private void OnDisable()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerController playerControl = playerObject.GetComponent<PlayerController>();
            playerControl.m_bombAction -= BombActionPlaneA;
        }

        void BombActionPlaneA()
        {
            GetHit(100000);
        }
    }
}