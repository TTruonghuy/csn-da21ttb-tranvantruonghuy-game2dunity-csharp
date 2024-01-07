using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FloatingJoystick : Joystick
{
    public Vector2 pois = new Vector2(52.5f, 49.2f);
    protected override void Start()
    {
        base.Start();
        background.gameObject.SetActive(true);
        pois = background.anchoredPosition;

    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        background.gameObject.SetActive(true);
        base.OnPointerDown(eventData);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        background.gameObject.SetActive(true);
        base.OnPointerUp(eventData);
        background.anchoredPosition = pois;
        
    }
}