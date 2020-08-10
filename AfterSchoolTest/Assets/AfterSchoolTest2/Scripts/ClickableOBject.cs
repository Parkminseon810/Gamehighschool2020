using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableOBject : MonoBehaviour
{
    public void OnPointerDown(BaseEventData eventData)
    {
        Debug.Log("오브젝트를 눌렀습니다.");
    }

}
