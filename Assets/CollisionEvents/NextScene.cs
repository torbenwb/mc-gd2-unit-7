using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int nextScene = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player")) SceneManager.LoadScene(nextScene);
    }
}
