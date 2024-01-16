using UnityEngine;

public class PatrolArea : MonoBehaviour
{
    public float radius = 5f;

    // Random position in radius
    public Vector3 GetTargetPosition()
    {
        Vector3 direction = Random.insideUnitSphere;
        direction.y = 0f;
        direction.Normalize();
        float range = Random.Range(0f, radius);
        return transform.position + direction * range;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
