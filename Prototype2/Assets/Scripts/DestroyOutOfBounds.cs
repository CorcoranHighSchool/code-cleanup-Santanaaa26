using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private const string gameover "GameOver";

    // Update is called once per frame
    void Update()
    {
        //destroy out of top bound
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //destroy out of lower bound
        if (transform.position.z < lowerBound)
        {
            //Log "Game over to the console
            Debug.Log(gameover);
            Destroy(gameObject);
        }
    }
}
