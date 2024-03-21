using UnityEngine;
using DG.Tweening;

public class ScaleTo : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _durationScale;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DOScale(_scale, _durationScale).SetDelay(_delay);
    }
}
