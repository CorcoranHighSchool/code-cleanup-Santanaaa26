using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private const string horizontal = "Horizontal";

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(horizontal);
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
