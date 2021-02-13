using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joypad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform rectBack;
    [SerializeField] private RectTransform recFront;
    private float radius;

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rectBack.position;
        value = Vector2.ClampMagnitude(value, radius);
        recFront.localPosition = value;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        recFront.localPosition = Vector3.zero;
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
