using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        Vector3 vec3 = this.transform.eulerAngles;
        vec3.y += 20 * Time.deltaTime;
        vec3.y %= 360;
        vec3.x += 10 * Time.deltaTime;
        vec3.x %= 360;
        this.transform.eulerAngles = vec3;
    }
}
