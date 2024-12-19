using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullets : MonoBehaviour
{
    [SerializeField] Transform avionParaSeguir;
    [SerializeField] GameObject instBullet;
    [SerializeField] float speed;
    [SerializeField] float yMax;
    Vector3 avionPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        instBullet.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void OnCreateBullets ()
    {
        avionPos = avionParaSeguir.position;
        Instantiate(instBullet, avionPos, Quaternion.identity);
    }
}
