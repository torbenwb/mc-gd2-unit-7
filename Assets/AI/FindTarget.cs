using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FindTarget
{
    public static GameObject FindNearestTargetInRange(Vector3 center, float range, string tag)
    {
        GameObject target = null;
        float minDistance = range;
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject gameObject in gameObjects)
        {
            float distance = (gameObject.transform.position - center).magnitude;
            if (distance <= minDistance)
            {
                minDistance = distance;
                target = gameObject;
            }
        }
        return target;
    }
}
