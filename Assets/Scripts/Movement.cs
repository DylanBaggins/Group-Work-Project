using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f;

        transform.Translate(x, 0, 0);
        transform.Translate(0, y, 0);
    }
}
