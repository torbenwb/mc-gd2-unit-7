using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIController : MonoBehaviour
{
    ICharacterMovement characterMovement;

    public Vector3 targetPosition;
    public float stopRange = 1f;

    public UnityEvent onDestinationReached = new UnityEvent();

    bool destinationReached;
    bool DestinationReached
    {
        get => destinationReached;
        set
        {
            if (!destinationReached && value) onDestinationReached.Invoke();
            destinationReached = value;
        }
    }

    void Awake() => characterMovement = GetComponent<ICharacterMovement>();

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, targetPosition);
        float distance = (transform.position - targetPosition).magnitude;

        if (distance <= stopRange)
        {
            characterMovement.moveDirection = Vector3.zero;
            DestinationReached = true;
        }
        else
        {
            DestinationReached = false;
            characterMovement.moveDirection = targetPosition - transform.position;
        }
    }
}
