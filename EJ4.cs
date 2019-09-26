using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    Light mLight;
    // Start is called before the first frame update
    void Start()
    {
        mLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        mLight.intensity = 0.5f * transform.localScale.magnitude;
    }
}
