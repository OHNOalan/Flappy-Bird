using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject  _prefab;
    [SerializeField] private float  _time;
    [SerializeField] private float  _yClamp;

    private float _eclapsedTime;
    
    private void Update()
    {
        _eclapsedTime += Time.deltaTime;

        if (_eclapsedTime > _time)
        {
            SpawnObject();

            _eclapsedTime = 0f;
        }
    }

    private void SpawnObject()
    {
        float offsetY = UnityEngine.Random.Range(-_yClamp, _yClamp);

        Vector2 pos = new Vector2(this.transform.position.x, this.transform.position.y + offsetY);

        Instantiate(_prefab, pos, Quaternion.identity, this.transform);
    }
}
