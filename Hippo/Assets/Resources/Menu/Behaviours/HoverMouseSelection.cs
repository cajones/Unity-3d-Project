using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Renderer))]
public class HoverMouseSelection : MonoBehaviour
{
    public Color SelectedColor;

    private Color _previousColor;

    public void OnMouseEnter()
    {
        _previousColor = this.renderer.material.color;
        this.renderer.material.color = SelectedColor;
    }

    public void OnMouseExit()
    {
        this.renderer.material.color = _previousColor;
    }
}
