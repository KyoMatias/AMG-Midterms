using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSideLerp : MonoBehaviour
{

public GameObject EnemyRoot;
private Vector3 endposition;
private Vector3 PlayerPos;
private Vector3 StartPos;

[SerializeField] private Transform point0;
[SerializeField] private Transform point1;

[SerializeField] private Transform point2;

[SerializeField] private float movementDuration;

[SerializeField] private float toPlayer;

private float elapsed;
private float seg2elapsed;


    // Start is called before the first frame update
    void Start()
    {
        StartPos = point0.position;
        endposition = point1.position;
        PlayerPos = point2.position;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        float percentComplete = elapsed / movementDuration;

        EnemyRoot.transform.position = Vector3.Lerp(StartPos, endposition, percentComplete);

        if(EnemyRoot.transform.position == endposition)
        {
            StartCoroutine(ToPlayer());
        }
        
    }

    IEnumerator ToPlayer()
    {
        seg2elapsed +=Time.deltaTime;
        float toPlayerComplete =  seg2elapsed / toPlayer;
        EnemyRoot.transform.position = Vector3.Lerp(endposition, PlayerPos, toPlayerComplete);
        yield return null;
    }
}
