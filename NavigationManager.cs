```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager
{
    // Declare any variables you need for navigation
    private int currentSceneIndex;

    public void SetupNavigation()
    {
        // Initialize your navigation here
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void UpdateNavigation()
    {
        // Update your navigation here
        // This is just an example, you can implement your own navigation logic
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GoToPreviousScene();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GoToNextScene();
        }
    }

    public void GoToNextScene()
    {
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("This is the last scene.");
        }
    }

    public void GoToPreviousScene()
    {
        if (currentSceneIndex > 0)
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }
        else
        {
            Debug.Log("This is the first scene.");
        }
    }
}
```
