using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

  public float shootingSpeed;
  public GameObject bulletPrefab;
  public float fireRate;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

    // Check if it's time to shoot
    float timeSinceLastShot = Time.time - lastShotTime;
    if (timeSinceLastShot >= fireRate) {

      // Shoot the player
      GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
      bullet.GetComponent<Rigidbody2D>().AddForce(transform.forward * shootingSpeed);

      // Reset the timer
      lastShotTime = Time.time;
    }
  }

  private float lastShotTime;
}
