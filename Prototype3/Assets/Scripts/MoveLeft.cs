using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Movement Speed
    private float speed = 20.0f;
    // Player Controller
    private PlayerController playerControllerScript;
    // Left bounds
    private float leftBound = -15.0f;
    private const string player = "Player";
    private const string obstacle = "Obstacle";
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find(player).GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move left as long as the game is not over
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (speed * Time.deltaTime));
        }

        //Destroy this object if it is an obstacle and has gone too far
        if(transform.position.x <leftBound && gameObject.CompareTag(obstacle))
        {
            Destroy(gameObject);
        }
    }
}
