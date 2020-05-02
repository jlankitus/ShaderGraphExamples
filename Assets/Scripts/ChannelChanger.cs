using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelChanger : MonoBehaviour
{
    [SerializeField] 
    private Renderer tvRenderer;
    
    private void GetRandomChannel()
    {
        var randomTex = TextureManager.get.GetRandomTexture();
        foreach (var material in tvRenderer.materials)
        {
            material.SetTexture("tvTexture", randomTex as Texture);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetRandomChannel();
        }
    }
}
