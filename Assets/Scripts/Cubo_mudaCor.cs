using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_mudaCor : MonoBehaviour
{
    public bool color = false;
    GameObject[] cubes;

    public void Click()
    {
        color = true;
        cubes = GameObject.FindGameObjectsWithTag("cubes");
    }

    public void Update()
    {
        if (color)
        {
            new WaitForSeconds(0.2f);

            foreach (var item in cubes)
            {
                item.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }

        }

    }
}
