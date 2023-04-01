using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] ships;
    public int selectedShip;
    Rigidbody2D rb;
    void Start()
    {
        Application.targetFrameRate = 120;
        selectedShip = 1;
        StartShips();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 4);
    }

    void StartShips()
    {
        for (int i = 1; i <= ships.Length; i++)
        {
            if (i == selectedShip)
                ships[i - 1].SetActive(true);

            if (i != selectedShip)
                Destroy(ships[i - 1]);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            rb.velocity = new Vector2(0,4);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
