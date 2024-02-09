using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random=UnityEngine.Random;

public class ReqGen : MonoBehaviour
{
    public TextMeshPro Node1;
    public TextMeshPro Node2;
    public TextMeshPro Node3;

    private int node1;
    private int node2;
    private int node3;

    public static ReqGen Instance;


    // Start is called before the first frame update
void Awake()
{
    Instance = this;
}

    void Start()
    {
        int N1rng= Random.Range(100, 359);
        int N2rng= Random.Range(1, 150);
        int N3rng= Random.Range(200, 359);
        node1 = N1rng;
        node2 = N2rng;
        node3 = N3rng;
        Node1.text = node1.ToString();
        Node2.text = node2.ToString();
        Node3.text = node3.ToString();


    }

    // Update is called once per frame
    void Update()
    {
    }

    public int GetNode1()
    {
        return node1;
    }

    public int GetNode2()
    {
        return node2;
    }

    public int GetNode3()
    {
        return node3;
    }
    

}
