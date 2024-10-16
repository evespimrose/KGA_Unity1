using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    // �̱��� �ν��Ͻ�
    public static GameManager Instance { get; private set; }

    // ������ GameObject ����Ʈ�� Sprite ����Ʈ
    public List<GameObject> gameObjects;
    public List<Sprite> spriteList;
    public GameObject nebula;
    public List<Sprite> Nebulasprites;

    public GameObject planet;
    public List<Sprite> planetsprites;
    private void Awake()
    {
        // �̱��� ����
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ���� �ٲ� �ı����� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(nebula.transform.position.y < -25.0f)
        {
            Vector3 pos = nebula.transform.position;
            pos.y = Random.Range(12.0f, 16.0f);
            // x���� 0.5�� 6.7 ������ ���������� ����
            pos.x = Random.Range(-10f, 4f);
            nebula.transform.position = pos;

            Transform rendererTransform = nebula.transform.Find("Renderer");
            if (rendererTransform != null)
            {
                SpriteRenderer spriteRenderer = rendererTransform.GetComponent<SpriteRenderer>();
                if (spriteRenderer != null && Nebulasprites.Count > 0)
                {
                    spriteRenderer.sprite = Nebulasprites[Random.Range(0, Nebulasprites.Count)];
                }
            }
        }

        if (planet.transform.position.y < -15.0f)
        {
            Vector3 pos = planet.transform.position;
            pos.y = Random.Range(20.0f, 26.0f);
            // x���� 0.5�� 6.7 ������ ���������� ����
            pos.x = Random.Range(-4f, 4f);
            planet.transform.position = pos;

            Transform rendererTransform = planet.transform.Find("Renderer");
            if (rendererTransform != null)
            {
                SpriteRenderer spriteRenderer = rendererTransform.GetComponent<SpriteRenderer>();
                if (spriteRenderer != null && planetsprites.Count > 0)
                {
                    spriteRenderer.sprite = planetsprites[Random.Range(0, planetsprites.Count)];
                }
            }
        }
        // gameObjects ����Ʈ�� ��ȸ�ϸ鼭 GameObject�� transform.position�� ������Ʈ
        foreach (GameObject obj in gameObjects)
        {
            Vector3 pos = obj.transform.position;

            if (pos.y < -5.0f)
            {
                // y���� 10.0���� �缳��
                pos.y = Random.Range(10.0f, 16.0f);
                // x���� 0.5�� 6.7 ������ ���������� ����
                pos.x = Random.Range(-4f, 4f);
                obj.transform.position = pos;

                // �ڽ� ��ü �� "Renderer" �̸��� ���� ��ü�� ã�� SpriteRenderer ������Ʈ ��ü
                Transform rendererTransform = obj.transform.Find("Renderer");
                if (rendererTransform != null)
                {
                    SpriteRenderer spriteRenderer = rendererTransform.GetComponent<SpriteRenderer>();
                    if (spriteRenderer != null && spriteList.Count > 0)
                    {
                        // spriteList���� ���� Sprite ����
                        spriteRenderer.sprite = spriteList[Random.Range(0, spriteList.Count)];
                    }
                }

                Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.gravityScale = Random.Range(0.05f, 0.5f) * Time.deltaTime;
                }
            }
        }
    }
}
