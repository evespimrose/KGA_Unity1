using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    // 싱글톤 인스턴스
    public static GameManager Instance { get; private set; }

    // 관리할 GameObject 리스트와 Sprite 리스트
    public List<GameObject> gameObjects;
    public List<Sprite> spriteList;
    public GameObject nebula;
    public List<Sprite> Nebulasprites;

    public GameObject planet;
    public List<Sprite> planetsprites;
    private void Awake()
    {
        // 싱글톤 구현
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 파괴되지 않도록 설정
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
            // x값을 0.5와 6.7 사이의 랜덤값으로 설정
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
            // x값을 0.5와 6.7 사이의 랜덤값으로 설정
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
        // gameObjects 리스트를 순회하면서 GameObject의 transform.position을 업데이트
        foreach (GameObject obj in gameObjects)
        {
            Vector3 pos = obj.transform.position;

            if (pos.y < -5.0f)
            {
                // y값을 10.0으로 재설정
                pos.y = Random.Range(10.0f, 16.0f);
                // x값을 0.5와 6.7 사이의 랜덤값으로 설정
                pos.x = Random.Range(-4f, 4f);
                obj.transform.position = pos;

                // 자식 객체 중 "Renderer" 이름을 가진 객체를 찾아 SpriteRenderer 컴포넌트 교체
                Transform rendererTransform = obj.transform.Find("Renderer");
                if (rendererTransform != null)
                {
                    SpriteRenderer spriteRenderer = rendererTransform.GetComponent<SpriteRenderer>();
                    if (spriteRenderer != null && spriteList.Count > 0)
                    {
                        // spriteList에서 랜덤 Sprite 설정
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
