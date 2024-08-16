using UnityEngine;

public class Letterbox : MonoBehaviour
{
    public int targetWidth = 1920;
    public int targetHeight = 1080;
    public Color letterboxColor;

    void Start()
    {
        float targetAspect = (float)targetWidth / targetHeight;
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera camera = GetComponent<Camera>();

        if (scaleHeight < 1.0f)
        {
            Rect rect = camera.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            camera.rect = rect;
        }
        else
        {
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = camera.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            camera.rect = rect;
        }

        CameraClearFlags originalClearFlags = camera.clearFlags;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = letterboxColor;
    }
}



