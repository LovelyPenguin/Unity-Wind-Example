using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWindDirection : MonoBehaviour
{
    public Transform windDirection;
    public float windPower = 5f;
    private Vector3 setDirection;
    private Cloth myCloth;
    // Start is called before the first frame update
    void Start()
    {
        myCloth = GetComponent<Cloth>();
        setDirection = windDirection.forward;
        myCloth.externalAcceleration = setDirection * windPower;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushWind(Transform originPoint, float windPower)
    {
        Vector3 windDirection = (transform.position - originPoint.position).normalized;
        myCloth.externalAcceleration = windDirection * 25f;
        StopCoroutine("SetWorldWind");
        StartCoroutine("SetWorldWind", 1f);
    }
    IEnumerator SetWorldWind(int timer)
    {
        yield return new WaitForSeconds(timer);
        Debug.Log("Hello");

        myCloth.externalAcceleration = setDirection * this.windPower;
    }
}
