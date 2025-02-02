using UnityEngine;
using UnityEngine.UI;

public class ChangeHuePerTime : MonoBehaviour
{
    public Image targetImage; // Assign your UI Image here
    public float speed = 1.0f; // Speed of hue shift

    private void Update()
    {
        if (targetImage != null)
        {
            // Get the current color in RGB
            Color currentColor = targetImage.color;

            // Convert RGB to HSV
            Color.RGBToHSV(currentColor, out float h, out float s, out float v);

            // Shift the hue value over time
            h += speed * Time.deltaTime;
            if (h > 1) h -= 1; // Keep hue in valid range

            // Convert back to RGB and apply it to the image
            targetImage.color = Color.HSVToRGB(h, s, v);
        }
    }
}
