using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") ; 
        float z = Input.GetAxis("Vertical") ;

        // �����GameObject������Rigidbody�R���|�[�l���g���擾
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbody��x���i���j��z���i���j�ɗ͂�������
        rigidbody.AddForce(speed * x, 0, speed * z);

    }
}
