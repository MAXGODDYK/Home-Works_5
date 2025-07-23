using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Teleport : MonoBehaviour
{
    [SerializeField] private float _teleportX = 5f;
    [SerializeField] private float _teleportZ = 5f;
    [SerializeField] private GameObject _player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == collision.gameObject.name)
        {
            _player.transform.position = new Vector3(_teleportX, _player.transform.position.y, _teleportZ);
            Debug.Log("Teleported to: " + _player.transform.position);
        }

    }
}
