using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public Vector2 minBounds = new Vector2(-15, -6); // Set minimum X and Y bounds
    public Vector2 maxBounds = new Vector2(15, 6);   // Set maximum X and Y bounds

    private Camera _camera;

    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if (transform.position.x < minBounds.x)
            transform.position = new Vector3(minBounds.x, transform.position.y, transform.position.z);

        if (transform.position.x > maxBounds.x)
            transform.position = new Vector3(maxBounds.x, transform.position.y, transform.position.z);

        if (transform.position.y < minBounds.y)
            transform.position = new Vector3(transform.position.x, minBounds.y, transform.position.z);

        if (transform.position.y > maxBounds.y)
            transform.position = new Vector3(transform.position.x, maxBounds.y, transform.position.z);
    }
}
