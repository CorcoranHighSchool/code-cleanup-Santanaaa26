using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializedField] private float speed = 5.0f;
    [SerializedField] private GameObject focalPoint;
    public bool hasPowerup {get; private set;};
    private float powerUpStrength = 15.0f;
    [SerializedField] private GameObject powerupIndicator;
    private const string focalpoint = "Focal Point";

    private const string vertical = "Vertical";

    private const string powerup = "Powerup";

    private const string enemy = "Enemy"; 

    private const string collidedwith = "Collided with ";

    private const string powerupsetto = "with powerup set to ";
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find(focalpoint);
    }

    // Update is called once per frame
    void Update()
    {
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        float verticalInput = Input.GetAxis(vertical);
        playerRb.AddForce(focalPoint.transform.forward * speed * verticalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(powerup))
        {
            powerupIndicator.SetActive(true);   //
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountDownRoutine());
        }
    }

    private IEnumerator PowerUpCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.SetActive(false);      //
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemy) && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log(collided with + collision.gameObject.name +
                powerupsetto + hasPowerup);
            enemyRigidbody.AddForce(awayfromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
