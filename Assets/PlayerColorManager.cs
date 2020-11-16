using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    [SerializeField]private Color playerColor = Color.red;

    private void Start()
    {
        // Create a material with transparent diffuse shader
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
        material.color = playerColor;

        // assign the material to the renderer
        GetComponent<Renderer>().material = material;
    }

}
