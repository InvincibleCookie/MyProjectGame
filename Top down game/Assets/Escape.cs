using UnityEngine;

public class EscapeButtonSimulator : MonoBehaviour
{
    private void Update()
    {
        var escapeEvent = new UnityEngine.EventSystems.PointerEventData(UnityEngine.EventSystems.EventSystem.current);
        escapeEvent.button = UnityEngine.EventSystems.PointerEventData.InputButton.Left;
        UnityEngine.EventSystems.ExecuteEvents.ExecuteHierarchy(gameObject, escapeEvent, UnityEngine.EventSystems.ExecuteEvents.submitHandler);
    }
}
