using UnityEngine;

namespace Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }

        private void Update()
        {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
        }
    }
}