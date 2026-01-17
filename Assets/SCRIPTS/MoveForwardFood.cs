using UnityEngine;

public class MoveForwardFood : MonoBehaviour
{
    private float speed = 40.0f;
    void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}

