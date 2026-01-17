using UnityEngine;

public class moveforward : MonoBehaviour
{
    private float speed;   
    void Update()
    {
        speed = Random.Range(3, 7);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
