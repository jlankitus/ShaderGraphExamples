using System.Collections.Generic;
using UnityEngine;

public class TextureManager : MonoBehaviour {
    
    public List<Texture2D> doorTextures;
 
    private static TextureManager instance = null;
    public static TextureManager get {
        get {
            return instance;
        }
    }
    void Awake() {
        if (instance == null)
            instance = this;
        else
            Debug.LogWarning("You have more than one TextureManager in the scene.");
    }
    
    public Texture2D GetTexture(string name) {
        foreach (Texture2D texture in doorTextures) {
            if (texture.name == name) //IF we have found the texture
                return texture; //THEN return it
        }
       
        return null; //We didn't find a texture with name "name"
    }

    public Texture2D GetRandomTexture()
    {
        Random.seed = System.DateTime.Now.Millisecond;
        int index = Random.Range (0, doorTextures.Count);
        return doorTextures[index];
    }
}