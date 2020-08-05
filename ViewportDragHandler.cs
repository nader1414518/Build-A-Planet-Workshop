using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewportDragHandler : MonoBehaviour, IDragHandler
{
  
  public void OnDrag(PointerEventData eventData)
  {
    Plane plane = new Plane(Vector3.up, transform.position);
    
    Ray ray = eventData.pressEventCamera.ScreenPointToRay(eventData.position);
    float distance;
    
    if (plane.Raycast(ray, out distance))
    {
      transform.position = ray.origin + ray.direction * distance;
    }
  }
}
