using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public Image image;
    public int usesLeft;
    public double rarity;


    public Items(Image image, int usesLeft, double rarity)
    {
        this.image = image;
        this.usesLeft = usesLeft;
        this.rarity = rarity;
    }
}
