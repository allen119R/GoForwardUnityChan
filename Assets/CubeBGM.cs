using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBGM : MonoBehaviour
{

    // �n�ʂ̈ʒu
    private float groundLevel = -3.0f;

    BoxCollider2D boxCollider;


    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D�̃R���|�[�l���g���擾����i�ǉ��j
        this.boxCollider = GetComponent<BoxCollider2D>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
