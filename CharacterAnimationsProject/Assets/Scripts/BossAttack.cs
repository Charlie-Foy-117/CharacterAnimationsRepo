using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    //unity editor variables
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    private Vector3 offset;
    private Animator animate;

    //action: fire a projectile
    public void FireProjectile()
    {
        //clone the projectile 
        //delcare a variable to hold the cloned object
        GameObject clonedProjectile;
        //use instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        offset = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        //position the projectile on the player
        clonedProjectile.transform.position = offset; //optional: add an offset (use a public variable)

        //fire it in a direction
        //declare a variable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        //get the rigidbody from our projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        //set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;

        animate.SetFloat("roll", 1);
    }
}
