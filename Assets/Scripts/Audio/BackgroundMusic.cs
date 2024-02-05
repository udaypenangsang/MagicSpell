using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
	[SerializeField] private AudioClip backgroundMusic;
	private AudioSource audioSource;

	// You can set this flag to control whether the music is playing or not
	private bool isMusicEnabled = true;

	private void Start() {
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = backgroundMusic;
		audioSource.loop = true;
		// You can set other AudioSource properties here, like volume, pitch, etc.

		// Play the background music when the game starts
		PlayMusic();
	}

	public void PlayMusic() {
		if (isMusicEnabled && !audioSource.isPlaying) {
			audioSource.Play();
		}
	}

	public void StopMusic() {
		audioSource.Stop();
	}

	public void ToggleMusic() {
		if (isMusicEnabled) {
			StopMusic();
		} else {
			PlayMusic();
		}

		// Toggle the flag
		isMusicEnabled = !isMusicEnabled;
	}

	public void PauseBgm() {
		audioSource.Pause();
	}

	public void UnpauseBgm() {
		audioSource.UnPause();
	}
}
