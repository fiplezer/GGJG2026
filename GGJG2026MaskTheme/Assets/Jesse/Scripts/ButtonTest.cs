using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTest : MonoBehaviour
{
    public SpriteRenderer MaskPlaceholder;
    public Sprite Mask1;
    public Sprite Mask2;

    public void Top()
    {
        MaskPlaceholder.sprite = Mask1;
    }

    public void Bottom()
    {
        MaskPlaceholder.sprite = Mask2;
    }
}