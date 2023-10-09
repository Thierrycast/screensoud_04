using screensoud_04.Modelos;

namespace screensoud_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach(var artist in artistasOrdenados)
            {
                Console.WriteLine($"- {artist}");
            }
        }
    }
}
