using UnityEngine;

public class GameExit : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        // Camera mainCamera = Camera.main;
        //
        // if (mainCamera != null)
        // {
        //     Rect pixelRect = mainCamera.pixelRect;
        //
        //     Debug.Log($"Camera Viewport Pixel Size: Width = {pixelRect.width}, Height = {pixelRect.height}");
        // }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quit the application in builds
            Application.Quit();

            // For testing in the Editor (optional, wrap in preprocessor directive)
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}