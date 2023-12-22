```csharp
using UnityEngine;
using UnityEngine.UI;

public class CanvasScaler : MonoBehaviour
{
    // Declare a CanvasScaler component
    private UnityEngine.UI.CanvasScaler canvasScalerComponent;

    void Start()
    {
        // Get the CanvasScaler component from the current GameObject
        canvasScalerComponent = this.GetComponent<UnityEngine.UI.CanvasScaler>();
        
        // If there is no CanvasScaler component attached to the GameObject, add one
        if (canvasScalerComponent == null)
        {
            canvasScalerComponent = this.gameObject.AddComponent<UnityEngine.UI.CanvasScaler>();
        }

        // Call the SetupCanvas method
        SetupCanvas();
    }

    public void SetupCanvas()
    {
        // Set the UI Scale Mode to Scale With Screen Size
        canvasScalerComponent.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;

        // Set the reference resolution to 1080 x 1920 (portrait)
        canvasScalerComponent.referenceResolution = new Vector2(1080, 1920);

        // Set the Screen Match Mode to Match Width Or Height
        canvasScalerComponent.screenMatchMode = UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;

        // Set the Match to 0.5 so it equally considers matching with width and height
        canvasScalerComponent.matchWidthOrHeight = 0.5f;
    }
}
```
