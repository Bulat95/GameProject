using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeDevice : MonoBehaviour
{
    public void Operate()
    {
        Color red = new Color(1, 0, 0, 1);
        GetComponent<Renderer>().material.color = red;
    }
}
