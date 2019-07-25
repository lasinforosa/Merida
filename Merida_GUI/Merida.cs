using System;


public class Merida
{
    public
        const sbyte REI = 1;
        const sbyte DAMA = 2;
        const sbyte TORRE = 3;
        const sbyte ALFIL = 4;
        const sbyte CAVALL = 5;
        const sbyte PEO = 6;
        const sbyte BUIT = 0;
        const sbyte BLANC = 1;
        const sbyte NEGRE = -1;
        int [] MOVS_TORRE = { 1, 12, -1, -12 };
        int [] MOVS_CAVALL = { -23, -10, 14, 25, 23, 10, -14, -25 };
        int [] MOVS_PEOB = { -24, -12 };
        int [] MOVS_PEOB_CAPT = { -11, -13 };
        int [] MOVS_PEON = { 24, 12 };
        int [] MOVS_PEON_CAPT = { 11, 13 };
        int [] MOVS_REI = { -11, 1, 13, 12, 11, -1, -13, -12 };
        int [] MOVS_DAMA = { 1, 12, -1, -12, -11, 13, 11, -13 };

        int numPsJugades;

    private
        Posicio mainPos;


    public Merida()
	{
        numPsJugades = 0;
        // mainPos = new  Posicio();
        mainPos.posicioInicial();
        mainPos.imprimeixEscaquer();
        entradaJugades();
    }

    public void entradaJugades()
    {
        string s;
        int orig, desti;
        int vabe = 0;
        bool bucle = true;
        Jugada jugada;


        while (bucle == true)
        {

           

            jugada.setInicial(orig);
            jugada.setFinal(desti);
            jugada.setCorOCapt(0);

            /* genera pseudoJugades */
            // numPseudoJugades = generaJugada(&posPPAL, &pseudoJUG[0]);
            mainPos.updatePos(jugada);
            // System.out.printf("Nombre de pseudo jugades = %d \n",numPseudoJugades);
            mainPos.imprimeixEscaquer();

        } /* del for */
    }

    public int generaNoCapt(Posicio posTreball)
    {
        int origen, desti;
        int i;
        int compta;
        int numJugades = 0;

        for (i = 0; i < 16; i++)
        {
            origen = posTreball.getPecesNegres(i);

            switch (i)
            {

                case 0:     /* REI */
                    for (int j = 0; j < 8; j++)
                    {

                        desti = origen + MOVS_REI[j];
                        if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                        {
                        }
                        else
                        {

                            // anota jugada
                            numJugades++;
                            printf("%3d-%3d\n", origen, desti);
                        }

                    }
                    break;

                case 1:     /* DAMA */
                    for (int j = 0; j < MOVS_DAMA.length; j++)
                    {
                        compta = 1;
                        do
                        {
                            desti = origen + compta * MOVS_DAMA[j];
                            if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                            {
                                compta = 100;
                            }
                            else
                            {

                                // anota jugada
                                numJugades++;
                                printf("%3d-%3d\n", origen, desti);
                            }
                            compta++;
                        } while (compta <= MAX_DESPL);

                    }
                    break;

                case 2:     /* TORRE */
                case 3:
                    for (int j = 0; j < MOVS_TORRE.length; j++)
                    {
                        compta = 1;
                        do
                        {
                            desti = origen + compta * MOVS_TORRE[j];
                            if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                            {
                                compta = 100;
                            }
                            else
                            {

                                // anota jugada
                                numJugades++;
                                printf("%3d-%3d\n", origen, desti);
                            }
                            compta++;
                        } while (compta <= MAX_DESPL);

                    }
                    break;

                case 4:
                case 5:
                    for (int j = 0; j < MOVS_ALFIL.length; j++)
                    {
                        compta = 1;
                        do
                        {
                            desti = origen + compta * MOVS_ALFIL[j];
                            if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                            {
                                compta = 100;
                            }
                            else
                            {

                                // anota jugada
                                numJugades++;
                                printf("%3d-%3d\n", origen, desti);
                            }
                            compta++;
                        } while (compta <= MAX_DESPL);

                    }
                    break;

                case 6:     /* CAVALL */
                case 7:
                    for (int j = 0; j < MOVS_CAVALL.length; j++)
                    {

                        desti = origen + MOVS_CAVALL[j];
                        if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                        {
                        }
                        else
                        {

                            // anota jugada
                            numJugades++;
                            printf("%3d-%3d\n", origen, desti);
                        }

                    }
                    break;

                default: /* PEO */
                    for (int j = 0; j < MOVS_PEON.length; j++)
                    {

                        desti = origen + MOVS_PEON[j];
                        if (desti < 26 || desti > 117 || posTreball.getCassella(desti) == 99 || posTreball.getCassella(desti) != 0)
                        {
                        }
                        else
                        {

                            // anota jugada
                            numJugades++;
                            printf("%3d-%3d\n", origen, desti);
                        }

                    }
                    break;

            } // switch
        } // for

        return numJugades;
    }

}
