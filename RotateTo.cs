using UnityEngine;
using DG.Tweening;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _durationRotate;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DORotate(_rotate, _durationRotate).SetDelay(_delay);
    }
}