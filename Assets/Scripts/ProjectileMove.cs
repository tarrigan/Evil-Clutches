using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 6;

    public float increaseSpeed = 2;

    public int points = 100;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-transform.right * speed * Time.deltaTime);
        if (transform.position.x < -10)
        {

            Destroy(gameObject);

        }

    }

}
