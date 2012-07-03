using UnityEngine;
using System.Collections;
using System.Threading;
using System;

public static class AnimationExtensions
{
    private static Action<AnimationState> playAnimationCallback;

    public static bool HasAnimationStopped(this AnimationState source)
    {
        return source.normalizedTime == 0.0f;
    }


    public static void Play(this Animation source, string animationName, Action<AnimationState> complete)
    {
        playAnimationCallback = complete;
        source.Play();
        AnimationState animationState = source[animationName];
        Timer animTimer = new Timer(AnimtationTimer, animationState, 100, Timeout.Infinite);
    }

    private static void AnimtationTimer(object state)
    {
        var animationState = (AnimationState)state;
        Debug.Log("Fired");
        if (animationState.HasAnimationStopped())
        {
            if (playAnimationCallback != null)
                playAnimationCallback(animationState);
        }
    }
}
