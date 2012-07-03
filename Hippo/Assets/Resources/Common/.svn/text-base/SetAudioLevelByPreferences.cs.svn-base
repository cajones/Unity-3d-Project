using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioListener))]
public class SetAudioLevelByPreferences : MonoBehaviour
{
    private readonly GameRepository _gameRepository = new GameRepository();
    private AudioListener _audioListener;

    public void Awake()
    {
        _audioListener = GetComponent<AudioListener>();
    }

    public void Update()
    {
        var preferences = _gameRepository.Get().Preferences;
        _audioListener.enabled = preferences.IsAudioEnabled;
    }
}
