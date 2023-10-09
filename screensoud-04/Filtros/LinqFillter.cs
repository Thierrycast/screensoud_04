using screensoud_04.Modelos;

namespace screensoud_04.Filtros;

internal class LinqFillter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas do genero {genero}");
        foreach(var artist in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"lista de musicas do artista {artista}");
        foreach(var musica in musicasPorArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPelaTonalidade(List<Musica> musicas, String tonalidade)

    {
        string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        int key = Array.IndexOf(tonalidades, tonalidade);

    var musicasFiltradasPelaTonalidade = musicas.Where(musica => musica.Key!.Equals(key)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Listando musicas na tonalidade {tonalidades[key]}\n");
        foreach(var musica in musicasFiltradasPelaTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
