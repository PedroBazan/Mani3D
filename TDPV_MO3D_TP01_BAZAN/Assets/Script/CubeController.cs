
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;

    void Start()
    {
        cubeBehaviour = GetComponent<CubeBehaviour>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cubeBehaviour.StopRotation();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cubeBehaviour.RotateClockwise();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            cubeBehaviour.RotateCounterClockwise();
        }
    }
}
