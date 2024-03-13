using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFighter
{
    public class EnemyGenerator : MonoBehaviour
    {
        public GameControl m_gameControl;
        public List<GameObject> m_enemyPrefabList;

        public int m_indexMin = 0;
        public int m_indexMax = 0;

        public float m_xPosMin = -20;
        public float m_xPosMax = 20;
        public float m_yPosMin = 20;
        public float m_yPosMax = 30;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                float xPos = Random.Range(m_xPosMin, m_xPosMax);
                float yPos = Random.Range(m_yPosMin, m_yPosMax);
                int index = Random.Range(m_indexMin, m_indexMax);

                Vector3 pos = new Vector3(xPos, yPos, 0);
                GameObject obj = (GameObject)Instantiate(m_enemyPrefabList[index], pos, Quaternion.identity);
                m_gameControl.AddEnemy(obj);
            }

            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                m_gameControl.DeleteEnemyAll();
            }
        }
    }

}
