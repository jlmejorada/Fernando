using System.Collections.ObjectModel;
using ENT;

namespace BL
{
    public class BLManejadora
    {
        /// <summary>
        /// Según la dificultad tiene mas casillas
        /// </summary>
        /// <param name="dif"></param>
        /// <returns></returns>
        public static int BLCuantasCasillas(int dif)
        {
            switch (dif)
            {
                case 1:
                    return 2;
                case 2:
                    return 3;
                case 3:
                    return 3;
                case 4:
                    return 4;
                case 5:
                    return 4;
                case 6:
                    return 5;
                case 7:
                    return 5;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Según la dificultad tiene mas bombas
        /// </summary>
        /// <param name="dif"></param>
        /// <returns></returns>
        public static int BLCuantasNumBombas(int dif)
        {
            switch (dif)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                case 4:
                    return 5;
                case 5:
                    return 7;
                case 6:
                    return 10;
                case 7:
                    return 15;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Según la dificultad tiene que descubrir mas o menos casillas
        /// </summary>
        /// <param name="dif"></param>
        /// <returns></returns>
        public static int BLCuantasDescubiertas(int dif)
        {
            switch (dif)
            {
                case 1:
                    return 2;
                case 2:
                    return 3;
                case 3:
                    return 4;
                case 4:
                    return 5;
                case 5:
                    return 7;
                case 6:
                    return 10;
                case 7:
                    return 5;
                default:
                    return 0;
            }
        }
    }
}
