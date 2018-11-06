using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float panSpeed = 20f;
    public float panBorderThickness = 10f;

    public float scrollSpeed = 20f;
    public float minZ = -25;
    public float maxZ = -1;

    private Vector2 panLimit;
    public Vector2[] panLimits;
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        int n = (int)Mathf.Sqrt(Mathf.Pow(minZ - pos.z, 2));

        panLimit = panLimits[n];

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.z += scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);
        
        transform.position = pos;
	}

}
