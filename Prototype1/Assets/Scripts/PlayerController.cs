using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of the car
    private float speed = 20.0f;
    // Speed of turning
    private float turnSpeed = 40.0f;
    // Turning input
    private float horizontalInput;
    // Forward Input
    private float forwardInput;
    private const string vertical = "Vertical";
    private const string horizontal = "Horizontal";


    // Update is called once per frame
    void Update()
    {
        //Get the forward Input
        forwardInput = Input.GetAxis(vertical);
        //Get the horizontal Input
        horizontalInput = Input.GetAxis(horizontal);

        //Move the vehicle forward
        transform.Translate(Vector3.forward * (forwardInput * speed * Time.deltaTime);

        //Turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
