using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HorizontalMover : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float Speed = 1f;


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * Speed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;

        transform.position += new Vector3(h, 0, v);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "teleport1")
        {
            _player.transform.position = new Vector3(7, _player.transform.position.y, 7);
            Debug.Log("Teleported to: " + _player.transform.position);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        _player.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
        Debug.Log("Material changed to: " + other.GetComponent<Renderer>().material.name);
    }
}
