using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoting : MonoBehaviour
{

    public GameObject projectilePrefab; // Reference to the projectile prefab

    public float shootingForce = 10f; // The force with which the projectile is shot
    public Transform shootPoint;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Assuming Fire1 is your fire button (e.g., left mouse button)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Get the forward vector of the player (the direction the player is facing)
        Vector3 shootingDirection = transform.forward;

        // Instantiate the projectile at the player's position
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        // Get the Rigidbody component of the projectile
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Apply force to the projectile in the calculated direction
            rb.AddForce(shootingDirection.normalized * shootingForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Projectile prefab does not contain a Rigidbody component.");
        }
    }

}
