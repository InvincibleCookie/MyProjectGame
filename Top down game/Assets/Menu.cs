using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas;
    private bool isCanvasVisible = false;

    private void Start()
    {
        HideCanvas();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleCanvas();
        }
    }

    private void ToggleCanvas()
    {
        isCanvasVisible = !isCanvasVisible;
        canvas.enabled = isCanvasVisible;
    }

    private void HideCanvas()
    {
        isCanvasVisible = false;
        canvas.enabled = false;
    }
}
