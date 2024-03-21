using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetDelay(_delay);
    }
}
