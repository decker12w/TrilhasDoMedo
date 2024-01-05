using UnityEngine;
using UnityEngine.UI;

public class ScrollSpeedModifier : MonoBehaviour
{
    ScrollRect scrollRect;
    public float scrollSpeed = 0.5f;

    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }
    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            Vector2 newPos = scrollRect.normalizedPosition;
            newPos.y += Input.mouseScrollDelta.y * scrollSpeed;
            newPos.y = Mathf.Clamp(newPos.y, 0f, 1f);
            scrollRect.normalizedPosition = newPos;
        }
    }
}