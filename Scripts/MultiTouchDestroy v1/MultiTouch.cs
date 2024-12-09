using UnityEngine;

public class MultiTouch : MonoBehaviour
{   

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            HandleTouch(touch);
        }
    }

    private void HandleTouch(Touch touch)
    {
        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
            if ((hit.collider != null) && (gameObject.tag == "Enemy"))
            {                
                GameObject.Destroy(hit.collider.gameObject);                
            }
        }
    }   
}
