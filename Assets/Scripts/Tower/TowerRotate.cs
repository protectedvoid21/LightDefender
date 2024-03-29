using UnityEngine;

class TowerRotate : MonoBehaviour
{
    public Transform head;
    public Vector3 angleOffset;

    private EnemySelector _selector;

    void Awake()
    {
        _selector = GetComponent<EnemySelector>();
    }

    void Update()
    {
        Enemy enemy = _selector.Enemy;
        if (enemy == null)
            return;

        // Vector3 direction = enemy.transform.position - transform.position;
        // Vector2 dir2D = new Vector2(direction.x, direction.z);
        // if (dir2D.magnitude < 0.01f)
        // {
        //     return;
        // }
        // direction.Normalize();

        // Vector3 dir = new Vector3(direction.x, 0, direction.z);

        // Quaternion rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(angleOffset);
        // head.rotation = rotation;
        head.LookAt(enemy.transform.position);
        head.rotation *= Quaternion.Euler(angleOffset);
    }
}