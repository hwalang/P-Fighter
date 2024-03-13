using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PFighter;

public class PlayerMissleController : MonoBehaviour
{
    float m_speed = 30.0f;
    public int m_damage = 10;
    public AudioSource[] m_audioSources;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            return;     // 적과 충돌한 경우만 파괴할 예정
        }

        m_audioSources[1].Play();
        
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null )
        {
            enemy.GetHit(m_damage);
        }

    }

    void Start()
    {
        m_audioSources = GetComponents<AudioSource>();
        m_audioSources[0].Play();
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * m_speed);
    }
}
