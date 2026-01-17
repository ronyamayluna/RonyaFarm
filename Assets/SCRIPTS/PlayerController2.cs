using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRangeone = 30f;
    [SerializeField] float xRangetwo = 40f;
    [SerializeField] GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // left boundary
        if (transform.position.x < xRangeone)
        {
            transform.position = new Vector3(xRangeone, transform.position.y, transform.position.z);
        }
        // right boundary
        if (transform.position.x > xRangetwo)
        {
            transform.position = new Vector3(xRangetwo, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}