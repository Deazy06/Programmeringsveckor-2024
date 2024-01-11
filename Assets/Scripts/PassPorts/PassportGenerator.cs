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
    List<string> fakePlanets = new List<string> {
    "Nebulon Prime Alpha",
    "Celestara IX Beta",
    "Zygora Minoris Prime",
    "Chronos Majoris Minor",
    "Vortexia Prime Omega",
    "Orionis Alpha Delta",
    "Lyra Nova Gamma",
    "Dracois Beta Prime",
    "Pegasus Majoris Omega",
    "Centauri Alpha Nova"
};

	public float z = 0;
    public int value;
	const int baseFakeValue = 5;

	public void Generate()
	{
		string firstName = PickRandomFromList(firstNames) + " ";
		string surname = PickRandomFromList(surNames);
		string planet = PickRandomFromList(planets);

		bool isLetterValid = true;

		value = Random.Range(1, 10);
        print(value);

		//generate incorrect letter
		if (value >= baseFakeValue)
		{
			isLetterValid = false;
				planet = PickRandomFromList(fakePlanets) + " is FAKE";
                print("fake!");
		}

		string address = firstName + surname + "\n" + planet;

		z+= .2f;
		if (z > 8.5)
			z = 0;

        print(firstName);
        print(planet);
        print(surname);
	}
	string PickRandomFromList(List<string> list)
	{
		int index = Mathf.RoundToInt(Random.Range(0, list.Count));

		return list[index];
	}
}