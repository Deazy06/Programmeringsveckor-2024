using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportGenerator : MonoBehaviour
{
        List<string> firstNames = new List<string> {
    "Zarnak",
    "Xylara",
    "Quorin",
    "Vylis",
    "Nexara",
    "Zephyrion",
    "Lyrion",
    "Dravax",
    "Synthara",
    "Gralnak"};
    List<string> surNames = new List<string> {
    "Vortis",
    "Xandros",
    "Kyralis",
    "Zenthos",
    "Vorlonis",
    "Thalrak",
    "Grythonix",
    "Sylaris",
    "Quixar",
    "Xyloxis"};
    List<string> planets = new List<string> {
    "Nebulon Prime",
    "Celestara IX",
    "Zygora Minor",
    "Chronos Majoris",
    "Vortexia Prime",
    "Orionis Alpha",
    "Lyra Nova",
    "Dracois Beta",
    "Pegasus Majoris",
    "Centauri Alpha"};
    List<string> fakePlantes = new List<string> {
};

    int difficulty = 0;
	public float z = 0;

	const int baseFakeValue = 6;

	public void SetDifficulty(int newDifficulty)
	{
		difficulty = newDifficulty;
	}

	public void Generate()
	{
		string firstName = PickRandomFromList(firstNames) + " ";
		string surname = PickRandomFromList(surNames);
		string planet = PickRandomFromList(planets);

		bool isLetterValid = true;

		int value = Random.Range(1, baseFakeValue + 1 + difficulty);

		//generate incorrect letter
		if (value >= baseFakeValue)
		{
			isLetterValid = false;

			switch (value)
			{
				case baseFakeValue+4:
					//fake city
					planet = PickRandomFromList(fakePlantes);
					break;
			}

		}

		string address = firstName + surname + "\n" + "\n" + planet;

		z+= .2f;
		if (z > 8.5)
			z = 0;
	}

	//Letter MakeEvilLetter()
	//{
	//	return new Letter();
	//}

	string PickRandomFromList(List<string> list)
	{
		int index = Mathf.RoundToInt(Random.Range(0, list.Count));

		return list[index];
	}
}