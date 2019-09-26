using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Renderer mRender;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        mRender = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        Color r = new Color(1, 0, 0);
        Color b = new Color(0, 0, 1);
        Color p = new Color(1, 0, 1);
        t += Time.deltaTime;
        if (t <= 3) mRender.material.color = r;
        if (t > 3 && t<=6) mRender.material.color = b;
        if (t > 6) mRender.material.color = p;
    }
}
