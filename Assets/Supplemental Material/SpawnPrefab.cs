using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public void Spawn_Prefab(GameObject prefab)
    {
        Instantiate(prefab, transform.position, transform.rotation); 
    }
}
