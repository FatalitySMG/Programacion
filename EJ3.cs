using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{
    //Crear un componente propio (un script) llamado:  Ej3, que revisa la intensidad de la luz y cambia el color (de la luz) dependiendo de esta.
    //Azul si la intensidad está entre 0.25 y 0.5, Rojo si está entre 0.5 y 0.75, Blanca si es mayor o igual a 0.75

    Renderer mRender;
    Light mLight;
    // Start is called before the first frame update
    void Start()
    {
        mRender = GetComponent<Renderer>();
        mLight = GetComponent<Light>();
        mLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mLight.intensity += 0.01f;
        Color r = new Color(1, 0, 0);
        Color b = new Color(0, 0, 1);
        Color w = new Color(1, 1, 1);
        if (mLight.intensity > 0.25 && mLight.intensity < 0.5) mRender.material.color = b;
        if (mLight.intensity > 0.5 && mLight.intensity < 0.75) mRender.material.color = r;
        if (mLight.intensity > 0.75) mRender.material.color = w;
    }
}
          
