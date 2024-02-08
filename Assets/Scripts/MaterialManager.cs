using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    public static MaterialManager instance;
    [SerializeField] private Material[] activeColor = new Material[3];
    // Start is called before the first frame update


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameObject.GetComponent<Renderer>().material = activeColor[activeColor.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
