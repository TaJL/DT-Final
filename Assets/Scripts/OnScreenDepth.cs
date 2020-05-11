using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreenDepth : MonoBehaviour
{
    [SerializeField] private Material material;



    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest,material);
    }
}
