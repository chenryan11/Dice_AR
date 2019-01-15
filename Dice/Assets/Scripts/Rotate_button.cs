using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate_button : MonoBehaviour
{
    public Button Stop;
    public Button Roll;

    void Start()
    {
        Stop.onClick.AddListener(StopOnclick);
        Roll.onClick.AddListener(RollOnclick);
    }

    private void StopOnclick()
    {
        enabled = false;
    }

    private void RollOnclick()
    {
        enabled = true;
    }

    void Update()
    {
        Vector3 vec3 = this.transform.eulerAngles;
        vec3.y += 30 * Time.deltaTime;
        vec3.y %= 360;
        vec3.x += 30 * Time.deltaTime;
        vec3.x %= 360;
        this.transform.eulerAngles = vec3;
    }
}
