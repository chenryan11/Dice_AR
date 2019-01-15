using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_fast : MonoBehaviour
{
    void Update()
    {
        Vector3 vec3 = this.transform.eulerAngles;
        vec3.y += 150 * Time.deltaTime;
        vec3.x %= 360;
        vec3.x += 150 * Time.deltaTime;
        vec3.y %= 360;
        this.transform.eulerAngles = vec3;
    }
}
