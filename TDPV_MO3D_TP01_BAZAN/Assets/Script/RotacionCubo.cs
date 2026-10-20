
using UnityEngine;

public class RotacionCubo : MonoBehaviour
{
    public float velocidadRotacion = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -velocidadRotacion * Time.deltaTime);
        }
    }
}
