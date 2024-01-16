using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviorController : MonoBehaviour
{
    public PatrolBehavior patrolBehavior;
    public FollowBehavior followBehavior;
    public float range;
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject followTarget = FindTarget.FindNearestTargetInRange(transform.position, range, tag);
        if (followTarget)
        {
            followBehavior.followTarget = followTarget;
            followBehavior.enabled = true;
            patrolBehavior.enabled = false;
        }
        else
        {
            followBehavior.enabled = false;
            patrolBehavior.enabled = true;
        }
    }
}
