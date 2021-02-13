using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joypad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform rectBack;
    [SerializeField] private RectTransform recFront;
    private float radius;

    private Vector3 input = Vector3.zero;
    public float Horizontal { get { return input.x; } }
    public float Vertical { get { return input.y; } }

    public void OnDrag(PointerEventData eventData)
    {
        input = Vector2.ClampMagnitude(
            eventData.position - (Vector2)rectBack.position,
            radius);
        recFront.localPosition = input;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        recFront.localPosition = input = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        radius = rectBack.rect.width * 0.5F;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
