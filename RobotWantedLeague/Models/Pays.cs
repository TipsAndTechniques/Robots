namespace RobotsWantedLeague.Models;
public class Pays
{
    public static Dictionary<string, string> countries = new Dictionary<string, string>
        {	
            { "Afrique du Sud", "Afrique" },
			{ "Nigéria", "Afrique" },
			{ "Kenya", "Afrique" },
			{ "Égypte", "Afrique" },
			{ "Maroc", "Afrique" },
			{ "Ghana", "Afrique" },
			{ "Sénégal", "Afrique" },
			{ "Tanzanie", "Afrique" },
			{ "Cameroun", "Afrique" },
			{ "Côte d'Ivoire", "Afrique" },
			{ "États-Unis", "Amérique du Nord" },
			{ "Canada", "Amérique du Nord" },
			{ "Mexique", "Amérique du Nord" },
			{ "Costa Rica", "Amérique du Nord" },
			{ "Panama", "Amérique du Nord" },
			{ "Jamaïque", "Amérique du Nord" },
			{ "Cuba", "Amérique du Nord" },
			{ "Honduras", "Amérique du Nord" },
			{ "Guatemala", "Amérique du Nord" },
			{ "République dominicaine", "Amérique du Nord" },
			{ "Brésil", "Amérique du Sud" },
			{ "Argentine", "Amérique du Sud" },
			{ "Pérou", "Amérique du Sud" },
			{ "Colombie", "Amérique du Sud" },
			{ "Chili", "Amérique du Sud" },
			{ "Équateur", "Amérique du Sud" },
			{ "Bolivie", "Amérique du Sud" },
			{ "Venezuela", "Amérique du Sud" },
			{ "Uruguay", "Amérique du Sud" },
			{ "Paraguay", "Amérique du Sud" },
			{ "Chine", "Asie" },
			{ "Inde", "Asie" },
			{ "Japon", "Asie" },
			{ "Russie", "Asie" },
			{ "Corée du Sud", "Asie" },
			{ "Arabie saoudite", "Asie" },
			{ "Iran", "Asie" },
			{ "Turquie", "Asie" },
			{ "Indonésie", "Asie" },
			{ "Thaïlande", "Asie" },
			{ "France", "Europe" },
			{ "Allemagne", "Europe" },
			{ "Royaume-Uni", "Europe" },
			{ "Espagne", "Europe" },
			{ "Italie", "Europe" },
			{ "Grèce", "Europe" },
			{ "Suède", "Europe" },
			{ "Pologne", "Europe" },
			{ "Ukraine", "Europe" },
			{ "Portugal", "Europe" },
			{ "Australie", "Océanie" },
			{ "Nouvelle-Zélande", "Océanie" },
			{ "Papouasie-Nouvelle-Guinée", "Océanie" },
			{ "Fidji", "Océanie" },
			{ "Îles Salomon", "Océanie" },
			{ "Vanuatu", "Océanie" },
			{ "Tonga", "Océanie" },
			{ "Samoa", "Océanie" },
			{ "Nauru", "Océanie" },
			{ "Tuvalu", "Océanie" }
            // Add more countries here...
        };

    // private static void Main(string[] args)
    // {
    //     Console.WriteLine(IsCountryExists("Tuvalu").ToString());
    //     foreach (var pair in countries)
    //     {
    //         Console.WriteLine($"Country {pair.Key}: Continent={pair.Value}");
    //     }
    // }
    public static bool IsCountryExists(string tryCountry)
    {
        return countries.ContainsKey(tryCountry);
    }

	public static bool newMethod(string tryCountry)
    {
        return countries.ContainsKey(tryCountry);
    }
}