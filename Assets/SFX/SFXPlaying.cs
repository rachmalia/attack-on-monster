using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {

	public AudioSource monster1;
	public AudioSource monster2;
	public AudioSource monster3;
	public AudioSource monster4;
	public AudioSource monster5;
	public AudioSource monster6;
	public AudioSource opening;
	public AudioSource backsound;
	public AudioSource ambilKartu;
	public AudioSource button;
	public AudioSource dice;
	public AudioClip buttonClickSound;
	public AudioClip buttonMouseOverSound;
	public AudioClip diceRollSound;

	public void playMonster1()
	{
		monster1.Play();
	}

	public void playMonster2()
	{
		monster2.Play();
	}

	public void playMonster3()
	{
		monster3.Play();
	}

	public void playMonster4()
	{
		monster4.Play();
	}

	public void playMonster5()
	{
		monster5.Play();
	}

	public void playMonster6()
	{
		monster6.Play();
	}

	public void playOpening()
	{
		opening.Play();
	}

	public void playAmbilKartu()
	{
		ambilKartu.Play();
	}

	public void playBacksound()
	{
		backsound.Play();
	}

	public void mouseOverSound(){
		button.PlayOneShot(buttonMouseOverSound);
	}

	public void clickSound(){
		button.PlayOneShot(buttonClickSound);
	}

	public void diceSound(){
		dice.PlayOneShot(diceRollSound);
	}
}
