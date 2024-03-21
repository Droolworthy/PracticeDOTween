using UnityEngine;
using DG.Tweening;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DORotate(_rotate, _duration).SetDelay(_delay);
    }
}
