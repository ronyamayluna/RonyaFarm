using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour
{
    [SerializeField] float delaySeconds = 10f;
    [SerializeField] Material[] materials;
    int currentindex = 0;
    [SerializeField] Renderer targetRenderer;



    //void Start()
    //{
    //    if (targetRenderer == null)
    //    {
    //        targetRenderer = GetComponent<Renderer>();
    //        if (targetRenderer == null)
    //        {
    //            Debug.LogError("Target Renderer is not assigned and no Renderer component was found on the GameObject.");
    //            return;
    //        }
    //    }

    //    StartCoroutine(ChangeColorWithDelay());
    //}
    void Update()
    {
        StartCoroutine(ChangeColorWithDelay()); // Исправлено: корректный вызов корутины
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


    //IEnumerator ChangeColorWithDelay()
    //{
    //    while (true)
    //    {
    //        yield return StartCoroutine(ColorFuction());
    //    }
    //}
}

