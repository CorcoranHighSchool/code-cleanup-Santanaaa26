using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //detect collisions and destroy this object and the other object
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
