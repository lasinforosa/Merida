using System;

public class Posicio
{
    public
        const sbyte Rb = 6;
        const sbyte Db = 5;
        const sbyte Tb = 4;
        const sbyte Ab = 3;
        const sbyte Cb = 2;
        const sbyte Pb = 1;
        const sbyte Rn = -6;
        const sbyte Dn = -5;
        const sbyte Tn = -4;
        const sbyte An = -3;
        const sbyte Cn = -2;
        const sbyte Pn = -1;
        const sbyte NEGRE = -1;
        const sbyte BLANC = 1;
        const sbyte BUIT = 0;

    private
        sbyte[,] tauler = new sbyte[8,8];
        sbyte[,] colorCasselles = new sbyte[8, 8];
        sbyte[] pecesBlanques = new sbyte[16];
        sbyte[] pecesNegres = new sbyte[16];
        
        //flags abas de jugFeta i després de la jugPrevia
        int enrocs; // 0 + 1 + 2 + 3 + 5 tots els enrocs
        int alPas;
        int ply;
        int torn;
        int rule3Rep;
        int rule50;
        Jugada jugPrevia, jugadaFeta;
        double hashPos;
        double valorPos;
        Jugada[] jugPsPosibles = new Jugada[255];



   
        

    public Posicio()
	{
        enrocs = 0;
        alPas = 0;
        ply = 1;
        torn = 1;
        rule3Rep = 0;
        rule50 = 50;
        hashPos = 0.0;
        valorPos = 0.0;
                
    }

    public void setPosicio(int[,] board, int[] blancas, int[] negras, int[,] colores, int enroques,
                            int alPaso, int halfmov, int mou, double hash, double elValor)
    {
        int i, j;

        for (i = 0; i < 8; i++)
        {
            for (j = 0; j < 8; j++)
            {

                tauler[i,j] = board[i,j];
                colorCasselles[i,j] = colores[i,j];
                if (i < 16)
                {
                    pecesBlanques[i] = blancas[i];
                    pecesNegres[i] = negras[i];
                }
            }
        }

        enrocs = enroques;
        alPas = alPaso;
        ply = halfmov;
        torn = mou;
        hashPos = hash;
        valorPos = elValor;
    }


    public int getCassella(int desti)
    {
        return tauler[0,desti];
    }

    public int getQuiMou()
    {
        return torn;
    }

    public int getPecesBlanques(int i)
    {
        return pecesBlanques[i];
    }

    public int getPecesNegres(int i)
    {
        return pecesNegres[i];
    }

    public void posicioInicial()
    {
        int i, j;

        pecesBlanques[0] = 61; pecesBlanques[1] = 60; pecesBlanques[2] = 57;
        pecesBlanques[3] = 64; pecesBlanques[4] = 59; pecesBlanques[5] = 62;
        pecesBlanques[6] = 58; pecesBlanques[7] = 63; pecesBlanques[8] = 49;
        pecesBlanques[9] = 50; pecesBlanques[10] = 51; pecesBlanques[11] = 52;
        pecesBlanques[12] = 53; pecesBlanques[13] = 54; pecesBlanques[14] = 55;
        pecesBlanques[15] = 56;
        pecesNegres[0] = 5; pecesNegres[1] = 4; pecesNegres[2] = 1;
        pecesNegres[3] = 8; pecesNegres[4] = 3; pecesNegres[2] = 6;
        pecesNegres[6] = 2; pecesNegres[7] = 7; pecesNegres[2] = 9;
        pecesNegres[9] = 10; pecesNegres[10] = 11; pecesNegres[2] = 12;
        pecesNegres[12] = 13; pecesNegres[13] = 14; pecesNegres[2] = 15;
        pecesNegres[15] = 16;

        colorCasselles[0,0] = NEGRE; colorCasselles[0,1] = NEGRE;
        colorCasselles[0,2] = NEGRE; colorCasselles[0,3] = NEGRE;
        colorCasselles[0,4] = NEGRE; colorCasselles[0,5] = NEGRE;
        colorCasselles[0,6] = NEGRE; colorCasselles[0,7] = NEGRE;
        colorCasselles[1,0] = NEGRE; colorCasselles[1, 1] = NEGRE;
        colorCasselles[1,2] = NEGRE; colorCasselles[1, 3] = NEGRE;
        colorCasselles[1,4] = NEGRE; colorCasselles[1, 5] = NEGRE;
        colorCasselles[1,6] = NEGRE; colorCasselles[1, 7] = NEGRE;
        colorCasselles[2,0] = BUIT; colorCasselles[2,1] = BUIT;
        colorCasselles[2,2] = BUIT; colorCasselles[2,3] = BUIT;
        colorCasselles[2,4] = BUIT; colorCasselles[2,5] = BUIT;
        colorCasselles[2,6] = BUIT; colorCasselles[2,7] = BUIT;
        colorCasselles[3, 0] = BUIT; colorCasselles[3, 1] = BUIT;
        colorCasselles[3, 2] = BUIT; colorCasselles[3, 3] = BUIT;
        colorCasselles[3, 4] = BUIT; colorCasselles[3, 5] = BUIT;
        colorCasselles[3, 6] = BUIT; colorCasselles[3, 7] = BUIT;
        colorCasselles[4, 0] = BUIT; colorCasselles[4, 1] = BUIT;
        colorCasselles[4, 2] = BUIT; colorCasselles[4, 3] = BUIT;
        colorCasselles[4, 4] = BUIT; colorCasselles[4, 5] = BUIT;
        colorCasselles[4, 6] = BUIT; colorCasselles[4, 7] = BUIT;
        colorCasselles[5, 0] = BUIT; colorCasselles[5, 1] = BUIT;
        colorCasselles[5, 2] = BUIT; colorCasselles[5, 3] = BUIT;
        colorCasselles[5, 4] = BUIT; colorCasselles[5, 5] = BUIT;
        colorCasselles[5, 6] = BUIT; colorCasselles[5, 7] = BUIT;
        colorCasselles[6,0] = BLANC; colorCasselles[6,1] = BLANC;
        colorCasselles[6,2] = BLANC; colorCasselles[6,3] = BLANC;
        colorCasselles[6,4] = BLANC; colorCasselles[6,5] = BLANC;
        colorCasselles[6,6] = BLANC; colorCasselles[6,7] = BLANC;
        colorCasselles[7,0] = BLANC; colorCasselles[7,1] = BLANC;
        colorCasselles[7,2] = BLANC; colorCasselles[7,3] = BLANC;
        colorCasselles[7,4] = BLANC; colorCasselles[7,5] = BLANC;
        colorCasselles[7,6] = BLANC; colorCasselles[7,7] = BLANC;

        enrocs = 11;              // 1 + 2 + 3 + 5
        alPas = 0;
        ply = 1;
        torn = BLANC;
        rule3Rep = 0;
        rule50 = 50;
        hashPos = 0.0;
        valorPos = 0.0;


        for (i = 0; i < 8; i++)
        {
            for (j = 0; j < 8; j++)
            {
                tauler[i, j] = BUIT;

            }
        }

        tauler[0, 0] = Tn; tauler[0, 1] = Cn; tauler[0, 2] = An; tauler[0, 3] = Dn;
        tauler[0, 4] = Rn; tauler[0, 5] = An; tauler[0, 6] = Cn; tauler[0, 7] = Tn;
        tauler[1, 0] = Pn; tauler[1, 1] = Pn; tauler[1, 2] = Pn; tauler[1, 3] = Pn;
        tauler[1, 4] = Pn; tauler[1, 5] = Pn; tauler[1, 6] = Pn; tauler[1, 7] = Pn;

        tauler[6, 0] = Pb; tauler[6, 1] = Pb; tauler[6, 2] = Pb; tauler[6, 3] = Pb;
        tauler[6, 4] = Pb; tauler[6, 5] = Pb; tauler[6, 6] = Pb; tauler[6, 7] = Pb;
        tauler[7, 0] = Tb; tauler[7, 1] = Cb; tauler[7, 2] = Ab; tauler[7, 3] = Db;
        tauler[7, 4] = Rb; tauler[7, 5] = Ab; tauler[7, 6] = Cb; tauler[7, 7] = Tb;

    }


    public void updatePos(Jugada jug)
    {
        tauler[jug.getFinal_Fila(), jug.getFinal_Columna()] = tauler[jug.getInicial_Fila(), jug.getInicial_Columna()];
        tauler[jug.getInicial_Fila(), jug.getInicial_Columna()]= BUIT;
        ply++;
        torn *=  NEGRE;
        /*
           enrocs, alPas, hashPos i valorPos  -> PENDENT
        */

        /* actualitzem els registres de Posicio */
        if (quiMou == BLANC)
        {
            if (colorCasselles[jug.getFinal()] == NEGRE)
            {
                pecesNegres[tauler[jug.getFinal()]] = BUIT;
                colorCasselles[jug.getFinal()] = BUIT;
            }
            pecesBlanques[tauler[jug.getInicial()]] = jug.getFinal();
        }
        else
        {
            if (colorCasselles[jug.getFinal()] == BLANC)
            {
                pecesBlanques[tauler[jug.getFinal()]] = BUIT;
                colorCasselles[jug.getFinal()] = BUIT;
            }
            pecesNegres[tauler[jug.getInicial()]] = jug.getFinal();
        }
        /* canvia el torn de joc */
        quiMou = quiMou * NEGRE;

    }

    public void imprimeixtauler()
    {
        int i;
        int compta = 0;
        char[] nomPeces = { 'K', 'Q', 'R', 'B', 'N', 'P', 'k', 'q', 'r', 'b', 'n', 'p' };

        printf("   +---+---+---+---+---+---+---+---+\n");
        printf("   +");

        for (i = 0; i < 64; i++)
        {

            switch (tauler[i])
            {

                case REI:
                    printf(" %c +", nomPeces[0]);
                    break;
                case -REI:
                    printf(" %c +", nomPeces[6]);
                    break;
                case DAMA:
                    printf(" %c +", nomPeces[1]);
                    break;
                case -DAMA:
                    printf(" %c +", nomPeces[7]);
                    break;
                case TORRE:
                    printf(" %c +", nomPeces[2]);
                    break;
                case -TORRE:
                    printf(" %c +", nomPeces[8]);
                    break;
                case ALFIL:
                    printf(" %c +", nomPeces[3]);
                    break;
                case -ALFIL:
                    printf(" %c +", nomPeces[9]);
                    break;
                case CAVALL:
                    printf(" %c +", nomPeces[4]);
                    break;
                case -CAVALL:
                    printf(" %c +", nomPeces[10]);
                    break;
                case PEO:
                    printf(" %c +", nomPeces[5]);
                    break;
                case -PEO:
                    printf(" %c +", nomPeces[11]);
                    break;

                default:
                    printf("   +");
                    break;
            }

            if ((i & 7) == 7)
            {
                compta++;
                printf(" %d", 9 - compta);
                printf("\n");
                printf("   +---+---+---+---+---+---+---+---+\n");
                printf("   +");
            }
        }

        printf(" a   b   c   d   e   f   g   h   \n");
    }
}
