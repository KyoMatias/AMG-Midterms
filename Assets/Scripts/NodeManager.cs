using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    [SerializeField] private int Val1;
    [SerializeField] private int Val2;
    [SerializeField] private int Val3;

    KnobParameters kb;
    
    private delegate void NodeStatus();
    private static NodeStatus SolveN1;

    [SerializeField] private bool n1solved;
    [SerializeField]private bool n2solved;
    [SerializeField]private bool n3solved;





    // Start is called before the first frame update
    
    void Awake()
    {
    }
    
    void Start()
    {
        n1solved = false;
        n2solved = false;
        n3solved = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckCorrection();
    }


    void CheckCorrection()
    {
        if(!n1solved)
        {
            SolveNode1();
        }
        else if (n1solved && !n2solved)
        {
            SolveNode2();
        }

        else if (n1solved && n2solved && !n3solved)
        {
            SolveNode3();
        }

    }
    void SolveNode1()
    {
        
        int LockValue = KnobParameters.Instance.GetCurrentAngle();
        Val1 = ReqGen.Instance.GetNode1();

            if(LockValue == Val1)
            {
                MaterialManager.TurnOn1?.Invoke();
                n1solved = ThrowNodeStatus(true);
            }

    }
    void SolveNode2()
    {
        int LockValue = KnobParameters.Instance.GetCurrentAngle();
        Val2 = ReqGen.Instance.GetNode2();

        if(LockValue == Val2)
        {
            MaterialManager.TurnOn2?.Invoke();
            n2solved = ThrowNodeStatus(true);
        }
    }

    void SolveNode3()
    {
        int LockValue = KnobParameters.Instance.GetCurrentAngle();
        Val3 = ReqGen.Instance.GetNode3();

        if(LockValue == Val3)
        {
            MaterialManager.TurnOn3?.Invoke();
            n3solved = ThrowNodeStatus(true);
        }
    }

    private bool ThrowNodeStatus(bool value)
    {
        return value;
    }
}


//Booleans
// - n1solved, n2solved, n3solved.
//Create a system that takes these parameters and settle them as functions or events.  