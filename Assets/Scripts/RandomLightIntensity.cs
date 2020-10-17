using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLightIntensity : MonoBehaviour
{
    public float maxRange = 1;
    public float minRange = 1;

    public float interval = 0.5f;

    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(Intensity());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Intensity()
    {
        yield return new WaitForSeconds(interval);
        light.intensity = Random.Range(minRange, maxRange);
        StartCoroutine(Intensity());
    }
}
