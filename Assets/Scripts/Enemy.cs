using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class Enemy : MonoBehaviour
    {
        public int HP = 10;
        public GameObject m_explosionPrefab;

        virtual public void GetHit(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Explode();
            }
        }

        private void Explode()
        {
            GameObject obj = GameObject.FindGameObjectWithTag("GameController");
            GameControl gameControl = obj.GetComponent<GameControl>();
            gameControl.DeleteEnemy(gameObject);

            GameObject explosion = (GameObject) Instantiate(m_explosionPrefab,
                gameObject.transform.position, Quaternion.identity);
            Destroy(explosion, 2.0f);
        }
    }

}

