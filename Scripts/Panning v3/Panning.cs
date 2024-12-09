using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panning : MonoBehaviour
{
    [SerializeField] [Range(0.01f, 15)] float speed;

    Vector3 panStart;
    Camera cam;

    public float speedMod = 2f;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panStart = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = panStart - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position += direction * speed * Time.deltaTime * speedMod;
        }
    }
}
