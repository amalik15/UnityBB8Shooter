using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded = false;
    public float speed = 100;
    public float jump = 40;

    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float bulletForce = 12.0f;
    public float gravity = -1.25f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, gravity, moveZ);

        rb.AddForce(movement * speed);
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }


    void Fire()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletForce;
        Destroy(bullet, 2.0f);
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }
}
