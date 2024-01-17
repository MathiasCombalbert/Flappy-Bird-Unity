using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float animationSpeed = 1f;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        //Fill this line to make the brackground sprite loop infinitely
        // meshRenderer.material.mainTextureOffset += ?;
    }

}