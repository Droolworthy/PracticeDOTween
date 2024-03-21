using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class СhangeText : MonoBehaviour
{
    [SerializeField] private Text _replacingText;
    [SerializeField] private Text _additionText;
    [SerializeField] private Text _hackingText;
    [SerializeField] private float _delay;
    [SerializeField] private float _duration;

    private void Start()
    {
        string replacingText = "Я заменил этот текст";
        string additionText = "\nЭто дополнение к тексту";
        string hackingText = "Я взломал этот текст";

        ScrambleMode scrambleMode = ScrambleMode.All;

        bool richTextEnabled = true;

        _replacingText.DOText(replacingText, _duration).SetDelay(_delay);
        _additionText.DOText(additionText, _duration).SetRelative().SetDelay(_delay);
        _hackingText.DOText(hackingText, _duration, richTextEnabled, scrambleMode).SetDelay(_delay);
    }
}