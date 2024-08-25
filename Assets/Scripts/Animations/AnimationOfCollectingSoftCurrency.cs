using UnityEngine;

public class AnimationOfCollectingSoftCurrency : MonoBehaviour
{
    public Vector2 _directionToMove;

    [SerializeField] private float _lifeTime = 1;

    [SerializeField] private float _speedMove = 350;

    [SerializeField] private float[] _valuesForRandomSpawn;//0-1 - X минимальное, максимальное; 2-3 - Y минимальное, максимальное
    private void Start()
    {
        Vector3 RandPosSpawnForTextObj = new Vector3(Random.Range(_valuesForRandomSpawn[0], _valuesForRandomSpawn[1]), Random.Range(_valuesForRandomSpawn[2], _valuesForRandomSpawn[3]), 0);
        transform.localPosition = RandPosSpawnForTextObj;
        _directionToMove = RandPosSpawnForTextObj.normalized;

        Destroy(gameObject, _lifeTime);
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(_directionToMove.x, _directionToMove.y,0) * _speedMove*Time.fixedDeltaTime;
    }
}
