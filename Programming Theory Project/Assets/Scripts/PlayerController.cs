using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //bullet prefab
    [SerializeField]
    GameObject bulletPrefab;

    //shooting positions
    [SerializeField]
    Transform l_shootingPosition;

    [SerializeField]
    Transform r_shootingPosition;

    //movement
    Rigidbody rb;
    float horizontalPower;
    //Vector3 apoint;

    [SerializeField]
    Transform shootingPoint;

    [SerializeField]
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.LookAt(new Vector3(0f, 0f, 0f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mousepos = Input.mousePosition;
        mousepos.z = 16.7f;
        Vector3 newpos = Camera.main.ScreenToWorldPoint(mousepos);

        horizontalPower = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * horizontalPower * Time.deltaTime * speed, ForceMode.Impulse);
        transform.LookAt(shootingPoint.position);
        shootingPoint.transform.position = newpos;

       

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepos = Input.mousePosition;
            mousepos.z = 16.7f;
            Vector3 newpos = Camera.main.ScreenToWorldPoint(mousepos);
            newpos.y = newpos.y + 1f;
            Instantiate(bulletPrefab, l_shootingPosition.position, l_shootingPosition.transform.rotation);
            Instantiate(bulletPrefab, r_shootingPosition.position, r_shootingPosition.transform.rotation);
        }
    }

    void OnMouseDown()
    {
        //Vector3 mousepos = Input.mousePosition;
        // mousepos.z = 20f;
        // Vector3 newpos = Camera.main.ScreenToWorldPoint(mousepos);
        

    }

}
