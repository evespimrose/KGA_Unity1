using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RendererProperties
{
    public Material material;       
    public Vector3 position;  
    public Vector3 scale;     
    public Vector3 rotation;
}

public class RendererManager : MonoBehaviour
{
    public Renderer[] renderers = new Renderer[10];
    public RendererProperties[] rendererProperties = new RendererProperties[10];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < renderers.Length; i++)
        {
            // 색상 변경
            if (renderers[i] != null)
            {
                renderers[i].material = rendererProperties[i].material;

                // 위치 변경
                renderers[i].transform.position = rendererProperties[i].position;

                // 크기 변경 (모양 변경)
                renderers[i].transform.localScale = rendererProperties[i].scale;

                // 각도 변경
                renderers[i].transform.eulerAngles = rendererProperties[i].rotation;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
