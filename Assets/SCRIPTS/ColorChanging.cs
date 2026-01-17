using UnityEngine;
using System.Collections;
public class ColorChanging : MonoBehaviour
{
    [SerializeField] float delaySeconds = 10f;
    [SerializeField] Material[] materials;
    int currentindex = 0;
    [SerializeField] Renderer targetRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ChangeColorWithDelay());
    }

    IEnumerator ChangeColorWithDelay()
    {
        yield return new WaitForSeconds(delaySeconds);
        while (true)
        {
            currentindex = (currentindex + 1) % materials.Length;
            targetRenderer.material = materials[currentindex];
            yield return new WaitForSeconds(delaySeconds);
        }
    }
}
