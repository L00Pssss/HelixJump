using UnityEngine;
using UnityEngine.UI;

public class PaletteChangeAll : MonoBehaviour
{
    [SerializeField] private Material axis;
    [SerializeField] private Material materialDefault;
    [SerializeField] private Material materialTrap;
    [SerializeField] private Material materialFinish;


    [SerializeField] private GameObject image; 
    [SerializeField] private new GameObject camera; 
    [SerializeField] private Material ball;

    Color[] color = new Color[6];
    private void Awake()
    {       
        for (int i = 0; i < color.Length; i++)
        {
            if (color[i] == color[0] || color[i] == color[1] || color[i] == color[2] || color[i] == color[3] || color[i] == color[4] || color[i] == color[5] )
            {
                color[i] = Random.ColorHSV(0f, .25f, 0.4f, 1f);
            }
            color[i] = Random.ColorHSV(0f, .25f, 0.4f, 1f);
        }
        Image image = GetComponent<Image>();
        RandomObjectColor();
    }
    private void RandomObjectColor()
    {
        axis.color = color[0];
        materialDefault.color = color[1];
        image.GetComponent<Image>().color = color[2];
        ball.color = color[3];
        materialTrap.color = color[4];
        materialFinish.color = color[5];
        camera.GetComponent<Camera>().backgroundColor = color[5];
    }
}
