using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class KnobParameters : MonoBehaviour
{
    
    [SerializeField] private TextMeshPro counter;
    
    private float m_currentAngle;

    public Transform Knob;
    
    // Start is called before the first frame update
    void Awake()
    {
        counter.text = m_currentAngle.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float Rotation;
        Rotation = Knob.eulerAngles.y;


        m_currentAngle = Rotation;
        counter.text = m_currentAngle.ToString("#");
        Debug.Log($"LogValues: {m_currentAngle}, {Rotation}");
    }
}
