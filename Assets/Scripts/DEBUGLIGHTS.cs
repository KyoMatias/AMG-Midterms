using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUGLIGHTS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            MaterialManager.TurnOn?.Invoke();
        }

        else if(Input.GetKeyDown(KeyCode.P))
        {
            MaterialManager.TurnOff?.Invoke();
        }
    }
}
