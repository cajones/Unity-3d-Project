using Engine;
using UnityEngine;

[RequireComponent(typeof(TextMesh))]
public class AudioStateSelector : MonoBehaviour
{
    private TextMesh _textMesh;
    private Preferences _preferences;
    private readonly GameRepository _gameRepository = new GameRepository();

    public int UpdateFrameRate = 20;

    public void Awake()
    {
        _textMesh = GetComponent<TextMesh>();
        _preferences = _gameRepository.Get().Preferences;
    }

    void OnMouseDown()
	{
	    ToggleAudioState();
	}

    private void ToggleAudioState()
    {
        _preferences.IsAudioEnabled = !_preferences.IsAudioEnabled;
    }

    void Update()
    {
        Limit.ByFrames(UpdateFrameRate, () => UpdateText());
    }

    private string UpdateText()
    {
        return _textMesh.text = _preferences.IsAudioEnabled ? "On" : "Off";
    }
}
