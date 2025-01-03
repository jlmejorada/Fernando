using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ENT;

namespace Buscaminas.Models;

public class ModelPartida
{
    #region ATRIBUTOS
    private int dificultad;

    private int numBombas;

    private int descubiertas;

    private ObservableCollection<ENTCasilla> tablero;

    private ENTCasilla seleccionada;
    #endregion

    #region PROPIEDADES
    public int Dificultad
    {
        get { return dificultad; }
    }
    public int Descubiertas
    {
        get { return descubiertas; }
    }
    public ENTCasilla Seleccionada { get { return seleccionada; } set { seleccionada.EstaRevelada = true; } }
    #endregion

    #region CONSTRUCTOR
    public ModelPartida(int dificultad)
    {
        this.dificultad = dificultad;
        this.numBombas = BL.BLManejadora.BLCuantasNumBombas(dificultad);
        this.descubiertas = BL.BLManejadora.BLCuantasDescubiertas(dificultad);
        this.tablero = anadeCasillas(dificultad);
        this.seleccionada = null;
    }
    #endregion

    #region METODOS
    /// <summary>
    /// Añade las casillas a una observable colection según su dificultad, enseñando cuales son bombas
    /// </summary>
    /// <param name="dificultad"></param>
    /// <returns></returns>
    public ObservableCollection<ENTCasilla> anadeCasillas(int dificultad)
    {
        int bombasRestantes = numBombas;
        int rand;
        ObservableCollection<ENTCasilla> lista = new ObservableCollection<ENTCasilla>();
        for (int i = 0; i < BL.BLManejadora.BLCuantasCasillas(dificultad); i++)
        {
           ENTCasilla casilla = new ENTCasilla(false);
           lista.Add(casilla);
        }
        Random random = new Random();
        while (bombasRestantes > 0)
        {
            rand = random.Next(lista.Count);
            if (!lista[rand].EsBomba)
            {
                lista[rand].EsBomba = true;

                bombasRestantes--;
            }
        }
        return lista;
    }
    #endregion
}