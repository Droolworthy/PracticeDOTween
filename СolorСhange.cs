using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class СolorСhange : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetDelay(_delay);
    }
}
