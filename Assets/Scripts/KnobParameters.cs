using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class KnobParameters : MonoBehaviour
{
    
    [SerializeField] private TextMeshPro counter;
    
    public float CurrentAngle;

    public static KnobParameters Instance;

    public Transform Knob;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        counter.text = CurrentAngle.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        KnobLive();
        Debug.Log($"LogValues: {CurrentAngle}");
    }

    public void KnobLive()
    {
        float Rotation;
        Rotation = Knob.eulerAngles.y;


       CurrentAngle = Rotation;
        counter.text = CurrentAngle.ToString("#");
    }

    public int GetCurrentAngle()
    {
        int value = Convert.ToInt32(CurrentAngle);
        return value;
    }
}
