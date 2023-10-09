using screensoud_04.Modelos;
using System.Text.Json;
using screensoud_04.Filtros;

using (HttpClient client = new HttpClient())
{

	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // LinqFillter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFillter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFillter.FiltrarMusicasPorArtista(musicas, "Red Hot Chili Peppers");

        var musicasPrefridasDoDaniel = new MusicasPreferidas("Daniel");
        // musicasPrefridasDoDaniel.AdicionarMusicasfavoritas(musicas[1]);
        // musicasPrefridasDoDaniel.AdicionarMusicasfavoritas(musicas[377]);
        // musicasPrefridasDoDaniel.AdicionarMusicasfavoritas(musicas[4]);
        // musicasPrefridasDoDaniel.AdicionarMusicasfavoritas(musicas[6]);
        // musicasPrefridasDoDaniel.AdicionarMusicasfavoritas(musicas[1467]);

        // musicasPrefridasDoDaniel.ExibirMusicasFavoritas();

        // musicasPrefridasDoDaniel.GerarArquivoJson();


        LinqFillter.FiltrarMusicasPelaTonalidade(musicas, "C#");

    }
    catch (Exception ex)
	{

        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}