using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class СhangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence().SetDelay(_delay);

        ScrambleMode scrambleMode = ScrambleMode.All;

        bool richTextEnabled = true;

        string replacingText = "Я заменил этот текст";
        string additionText = "\nЭто дополнение к тексту";
        string hackingText = "Я взломал этот текст";

        sequence.Append(_text.DOText(replacingText, _duration));
        sequence.Append(_text.DOText(additionText, _duration).SetRelative());
        sequence.Append(_text.DOText(hackingText, _duration, richTextEnabled, scrambleMode));
    }
}
