using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 6;

    public int points = 100;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-transform.right * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);

    }

}
