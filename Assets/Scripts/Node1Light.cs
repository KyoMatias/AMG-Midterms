using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node1Light : MonoBehaviour
{
    [SerializeField] private Material m_onMaterial;
    [SerializeField] private Material m_offMaterial;

    public GameObject light1;

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
            Material[] mats = light1.GetComponent<Renderer>().materials;
            mats[1] = m_onMaterial;
            light1.GetComponent<Renderer>().materials = mats;

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
