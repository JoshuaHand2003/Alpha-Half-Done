using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerController movement;

    void onCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
         
        {
            movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();

        }
    }

}
