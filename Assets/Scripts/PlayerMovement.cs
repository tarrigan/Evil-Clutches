using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 4;
    public float speedTimer = 0;
    private bool speedGet = false;
    private int score = 0;

    public TextMeshProUGUI scoreBox;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(transform.up * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(-transform.up * speed * Time.deltaTime);

        }

        if (speedGet)
        {

            speedTimer += Time.deltaTime;
            if (speedTimer >= 8)
            {

                speed -= 2; //hard coded to 2 bc lazy
                speedGet = false;

            }

        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Projectile")
        {

            if (collision.GetComponent<ProjectileMove>() != null)
            {

                score += collision.GetComponent<ProjectileMove>().points;
                scoreBox.text = "Score: " + score;

            }

            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "SpeedBoost") //increase speed when hitting speed thing
        {

            speedGet = true;
            speedTimer = 0;
            speed += collision.GetComponent<ProjectileMove>().increaseSpeed;
            Destroy(collision.gameObject);

        }

    }
}
