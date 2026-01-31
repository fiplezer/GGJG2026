using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTest : MonoBehaviour
{
    public SpriteRenderer MaskPlaceholder;
    public Sprite Mask1;
    public Sprite Mask2;
    public Sprite Mask3;
    public Sprite Mask4;

    public void TopLeft()
    {
        MaskPlaceholder.sprite = Mask4;
    }

    public void TopRight()
    {
        MaskPlaceholder.sprite = Mask1;
    }

    public void BottomLeft()
    {
        MaskPlaceholder.sprite = Mask3;
    }

    public void BottomRight()
    {
        MaskPlaceholder.sprite = Mask2;
    }
}