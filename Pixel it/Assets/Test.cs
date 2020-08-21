using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Mail;
using UnityEditor.PackageManager;
using Unity.Mathematics;

public class Test : MonoBehaviour
{
    public Texture2D myTexture;
    public Sprite mySprite;
    public Color MyPixel;
    int ii = 0;
    int jj = 0;

    void Start()
    {
        mySprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        myTexture = mySprite.texture;
        for (int x = 0; x < myTexture.width; x++)
        {
            for (int y = 0; y < myTexture.height; y++)
            {
                    myTexture.SetPixel(x, y, new Color32(255, 0, 0, 255));
            } 
        }
        myTexture.Apply();
    }

    public void Click()
    {
        for (int j = 0; j < 10; j++)
        {


            for (int i = 0; i < myTexture.width / 2; i++)
            {
                myTexture.SetPixel(ii, jj, new Color32(0, 0, 0, 0));
                ii++;
            }
            ii = 0;
            jj++;
        }
        myTexture.Apply();
    }
}
