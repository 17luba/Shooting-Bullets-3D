using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null )
            {
                rb.velocity = bulletSpawnPoint.forward * bulletSpeed; 
            }
            else
            {
                Debug.LogError("Le rigidbody est manquant sur le prefab balle !");
            }
        }
    }
}
