using UnityEngine;

public class balle : MonoBehaviour
{
    public float vie = 3;

    void Awake()
    {
        Destroy(gameObject, vie);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
