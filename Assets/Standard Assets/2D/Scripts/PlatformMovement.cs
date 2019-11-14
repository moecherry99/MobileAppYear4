using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    // Position 1 and 2 of platform
    private Vector3 posA;

    private Vector3 posB;

    private Vector3 nextPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;


    // Start is called before the first frame update
    void Start()
    {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        nextPos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // movement of platform
    private void Move()
    {
        //moves platform at speed assigned to other position (nextPos)
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);

        if(Vector3.Distance(childTransform.localPosition, nextPos) <= 0.1)
        {
            ChangeDestination();
        }

    }

    private void ChangeDestination()
    {
        // if next pos is A, it will swap to B and so on.
        nextPos = nextPos != posA ? posA : posB;
    }
}
