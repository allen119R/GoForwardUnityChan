using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour
{

    // 地面の位置
    private float groundLevel = -3.0f;

    BoxCollider2D boxCollider;


    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2Dのコンポーネントを取得する（追加）
        this.boxCollider = GetComponent<BoxCollider2D>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
