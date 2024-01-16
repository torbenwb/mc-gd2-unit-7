using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TreasureChest : MonoBehaviour
{
    public Mesh closedMesh;
    public Mesh openMesh;

    bool open = false;

    public UnityEvent OnOpen = new UnityEvent();
    public UnityEvent OnClose = new UnityEvent();

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        if (!open) Open();

    }

    public void Open()
    {
        open = true;
        GetComponent<MeshFilter>().mesh = openMesh;
        OnOpen.Invoke();
    }

    public void Closed()
    {
        open = false;
        GetComponent<MeshFilter>().mesh = closedMesh;
        OnClose.Invoke();
    }
}
