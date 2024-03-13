using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDPanelAndCube : MonoBehaviour
{
    public GameObject m_panelPrefab;
    public GameObject m_parent;
    public GameObject m_panel;

    public void ShowGeneratePanel()
    {
        GameObject panelPrefab = (GameObject)Instantiate(m_panelPrefab, Vector3.zero, Quaternion.identity);
        panelPrefab.transform.SetParent(m_parent.transform);
        RectTransform rt = (RectTransform)panelPrefab.transform;
        rt.anchoredPosition = new Vector2(0, 0);
        m_panel = panelPrefab;

        PanelControl panelControl = panelPrefab.GetComponent<PanelControl>();
        panelControl.Setup("Now Add one object", "Generate", GenerateObject);
    }

    public void ShowDestroyPanel()
    {
        GameObject panelPrefab = (GameObject)Instantiate(m_panelPrefab, Vector3.zero, Quaternion.identity);
        panelPrefab.transform.SetParent(m_parent.transform);
        RectTransform rt = (RectTransform)panelPrefab.transform;
        rt.anchoredPosition = new Vector2(0, 0);
        m_panel = panelPrefab;

        PanelControl panelControl = panelPrefab.GetComponent<PanelControl>();
        panelControl.Setup("Now Destroy All", "Remove All", DestroyObjects);
    }

    public List<GameObject> m_list;
    public GameObject m_prefab;

    void GenerateObject()
    {
        float x = Random.Range(-5, 5);
        float y = Random.Range(-5, 5);

        GameObject obj = (GameObject)Instantiate(m_prefab, new Vector3(x, y, 0), Quaternion.identity);
        m_list.Add(obj);

        if (m_panel != null)
        {
            Destroy(m_panel);
            m_panel = null;
        }
    }

    void DestroyObjects()
    {
        foreach (GameObject obj in m_list)
        {
            Destroy(obj);
        }

        m_list.Clear();

        if (m_panel != null)
        {
            Destroy(m_panel);
            m_panel = null;
        }
    }
}
