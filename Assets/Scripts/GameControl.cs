using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class GameControl : MonoBehaviour
    {
        public List<GameObject> m_enemyList = new List<GameObject>();

        public void AddEnemy(GameObject obj)
        {
            m_enemyList.Add(obj);
        }

        public void DeleteEnemy(GameObject obj)
        {
            Destroy(obj);
            m_enemyList.Remove(obj);
        }

        public void DeleteEnemyAll()
        {
            foreach (GameObject obj in m_enemyList)
            {
                Destroy(obj);
            }
            m_enemyList.Clear();
        }
    }
}

