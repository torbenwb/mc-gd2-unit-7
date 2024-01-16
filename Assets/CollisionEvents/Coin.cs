
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Coin : MonoBehaviour
{
    public static TextMeshProUGUI coinDisplay;
    public static int coins = 0;
    public float pullForce = 5f;
    public UnityEvent OnCollect = new UnityEvent();

    void Awake()
    {
        if (!coinDisplay)
        {
            coinDisplay = GameObject.FindWithTag("Coin Display").GetComponent<TextMeshProUGUI>();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Player")) return;
        coins++; if (coinDisplay){coinDisplay.text = $"COINS: {coins.ToString()}";}
        //Debug.Log($"coins: {coins}");
        OnCollect.Invoke();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player")) return;
        coins++; if (coinDisplay){coinDisplay.text = $"COINS: {coins.ToString()}";}
        //Debug.Log($"coins: {coins}");
        OnCollect.Invoke();
    }

    void OnTriggerStay(Collider other)
    {
        
        if (!other.CompareTag("Player")) return;
        Vector3 direction = other.gameObject.transform.position - transform.position;
        if (gameObject.TryGetComponent<Rigidbody>(out var rb))
        {
            rb.AddForce(direction * pullForce);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        
    }
}
