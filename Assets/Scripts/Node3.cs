using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node3 : MonoBehaviour
{
    [SerializeField] private Material m_onMaterial;
    [SerializeField] private Material m_offMaterial;

    public GameObject light3;

    public static bool m_isActivated;

    


    void Awake()
    {
        m_isActivated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_isActivated)
        {
            Material[] mats = light3.GetComponent<Renderer>().materials;
            mats[1] = m_onMaterial;
            light3.GetComponent<Renderer>().materials = mats;

        }
        else 
    m_isActivated = false;
         
    }


    public static bool ActivateStatus(bool toggle)
    {
        m_isActivated = toggle;
        return m_isActivated;
    }
}
