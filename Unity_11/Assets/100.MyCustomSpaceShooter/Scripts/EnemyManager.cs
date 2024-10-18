using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Enemy> enemies;
    public static EnemyManager Instance { get; private set; }

    private void Awake()
    {
        // ½Ì±ÛÅæ ±¸Çö
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ¾ÀÀÌ ¹Ù²î¾îµµ ÆÄ±«µÇÁö ¾Êµµ·Ï ¼³Á¤
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
