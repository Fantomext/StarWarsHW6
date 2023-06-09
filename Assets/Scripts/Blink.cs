using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] private Renderer[] _renderer;

    [SerializeField] private float amplitude = 22f;
    [SerializeField] private float timeBlink = 0.1f;


    public void StartBlink()
    {
        StartCoroutine(BlinkEffect());
    }

    public IEnumerator BlinkEffect()
    {

        for (float t = 0; t < timeBlink; t += Time.deltaTime)
        {
            SetColor(new Color(Mathf.Sin(t * amplitude) * 0.5f + 0.5f, 0, 0, 0));
            yield return null;
        }
        
        SetColor(Color.clear);

    }
    
    public void SetColor(Color color)
    {
        for (int i = 0; i < _renderer.Length; i++)
        {
            for (int m = 0; m < _renderer[i].materials.Length; m++)
            {
                _renderer[i].materials[m].SetColor("_EmissionColor", color);
             
            }
        }
    }

}
