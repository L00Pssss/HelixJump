using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string mouseInputAxis;
    [SerializeField] private float sentitive;
    private void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {
            transform.Rotate(0, Input.GetAxis(mouseInputAxis) * -sentitive, 0);
        }
    }
}
