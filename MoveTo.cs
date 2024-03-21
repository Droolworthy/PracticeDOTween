using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _durationMove;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetDelay(_delay);
    }
}
