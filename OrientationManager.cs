```csharp
using UnityEngine;

public class OrientationManager
{
    // Declare a variable to store the current device orientation
    private ScreenOrientation currentOrientation;

    public OrientationManager()
    {
        // Set the initial orientation to the current device orientation
        currentOrientation = Screen.orientation;
    }

    public void SetupOrientation()
    {
        // Set the preferred orientation based on your app's requirements
        // For example, if your app should only be in portrait mode:
        Screen.autorotateToPortrait = true;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;

        // Apply the orientation settings
        Screen.orientation = ScreenOrientation.AutoRotation;
    }

    public void UpdateOrientation()
    {
        // Check if the device orientation has changed
        if (currentOrientation != Screen.orientation)
        {
            // If the orientation has changed, update the currentOrientation variable
            currentOrientation = Screen.orientation;

            // Here you can add any additional code that should run when the device orientation changes
            // For example, you might need to adjust the layout of your UI
        }
    }
}
```
