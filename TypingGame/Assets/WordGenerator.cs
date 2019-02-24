using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordGenerator : MonoBehaviour {

    private static List<string> wordList = System.IO.File.ReadAllLines("Assets/Practice.cpp", System.Text.Encoding.UTF8).ToList<string>();

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Count);
		string randomWord = wordList[randomIndex];

        wordList.Remove(wordList[randomIndex]);
		return randomWord;
	}

}
