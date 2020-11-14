using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f)
        {
            Camera.main.transform.position += new Vector3(0, 0, 1);
        }
        else if (d < 0f)
        {
            Camera.main.transform.position += new Vector3(0, 0, -1);
        }
    }
}
