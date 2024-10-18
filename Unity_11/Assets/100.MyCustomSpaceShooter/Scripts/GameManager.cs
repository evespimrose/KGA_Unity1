using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    // 싱글톤 인스턴스
    public static GameManager Instance { get; private set; }

    // 관리할 GameObject 리스트와 Sprite 리스트
    public List<Enemy> enemies;
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

    private void Start()
    {
        
        foreach (Enemy enemy in enemies)
        {
            enemy.StartCoroutine(SpriteSetter(enemy));
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
    }

    private IEnumerator SpriteSetter(Enemy enemy)
    {
        while (true)
        {
            yield return new WaitUntil(() => enemy.isReborn);
            print($"{enemy.name}의 SpriteSetter 발동");
            enemy.isReborn = false;
            Transform rendererTransform = enemy.transform.Find("Renderer");
            if (rendererTransform != null)
            {
                SpriteRenderer spriteRenderer = rendererTransform.GetComponent<SpriteRenderer>();
                if (spriteRenderer != null && spriteList.Count > 0)
                {
                    // spriteList에서 랜덤 Sprite 설정
                    spriteRenderer.sprite = spriteList[Random.Range(0, spriteList.Count)];
                }
            }
        }

        
    }
}
