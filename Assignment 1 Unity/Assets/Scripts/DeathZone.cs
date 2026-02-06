using System.Collections;
using UnityEngine;

namespace GMPR2512.Assignment1
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] PointCounter _pointCounter;

        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.CompareTag("Ball"))
            {
                _pointCounter.ResetPoints();
                GameObject ball = collider2D.gameObject;
                StartCoroutine(RespawnBall(ball));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {
            yield return new WaitForSeconds(2); 
            ball.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            ball.transform.position = _spawnPoint.position;
        }
    } 
}
