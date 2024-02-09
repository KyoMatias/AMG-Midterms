using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    [SerializeField] private int Val1;
    [SerializeField] private int Val2;

    [SerializeField] private int Val3;

    KnobParameters kb;
    // Start is called before the first frame update
    
    void Awake()
    {
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckCorrection();
    }


    void CheckCorrection()
    {
        Val1 = ReqGen.Instance.GetNode1();
        Val2 = ReqGen.Instance.GetNode2();
        Val3 = ReqGen.Instance.GetNode3();
       int LockValue = KnobParameters.Instance.GetCurrentAngle();

        if(LockValue == Val1)
        {
            MaterialManager.TurnOn?.Invoke();
        }
        

    }
}
