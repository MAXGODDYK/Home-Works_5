using UnityEngine;

public class HorizontalMover : MonoBehaviour
{
    [SerializeField] private float _speed = 6f;
    [SerializeField] private Renderer _materialRenderer;

    private static string PlayerTag = "Untagged";

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        transform.position += new Vector3(h, 0, v);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            _materialRenderer.material = other.GetComponent<Renderer>().material;
            
        }
        Debug.Log("Material changed to: " + other.GetComponent<Renderer>().material.name);
    }
}
