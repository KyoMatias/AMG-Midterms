using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node1Light : MonoBehaviour
{
    [SerializeField] private Material m_onMaterial;
    [SerializeField] private Material m_offMaterial;

    private bool m_isActivated;




    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool ActivateStatus(bool toggle)
    {
        return toggle;
    }
}
