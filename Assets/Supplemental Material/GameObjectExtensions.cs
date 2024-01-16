using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static void SpawnPrefab(this GameObject gameObject, GameObject prefab)
    {
        MonoBehaviour.Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
