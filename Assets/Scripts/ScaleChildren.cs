using System.Collections;
using UnityEngine;

public class ScaleChildren : MonoBehaviour
{
    public float scaleDuration = 1f; 
    public Transform child1;
    public Transform child2;

    private void OnEnable()
    {   
        StartCoroutine(ScaleChildrenCoroutine());
    }

    private IEnumerator ScaleChildrenCoroutine()
    {
        
        yield return StartCoroutine(ScaleUp(child1));
        yield return StartCoroutine(ScaleUp(child2));
    }

    private IEnumerator ScaleUp(Transform target)
    {
        Vector3 originalScale = target.localScale;
        target.localScale = Vector3.zero;

        float elapsedTime = 0f;

        while (elapsedTime < scaleDuration)
        {
            target.localScale = Vector3.Lerp(Vector3.zero, originalScale, elapsedTime / scaleDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        target.localScale = originalScale;
    }
}
