using System;

public class Jugada
{
    private
        sbyte ini_fil, ini_col;
        sbyte fi_fil, fi_col;
        sbyte corOCapt;
        sbyte figMou;
        sbyte figCapt;


    public Jugada()
	{
	}

    public Jugada(sbyte fig, sbyte orig_fil, sbyte orig_col, sbyte desti_fil, sbyte desti_col, sbyte especial) {
	    ini_fil = orig_fil;
        ini_col = orig_col;
	    fi_fil =  desti_fil;
        fi_col = desti_col;
        corOCapt = especial;
        figMou = fig;
    }

    

    public sbyte getInicial_Fila()
    {
        return ini_fil;
    }

    public sbyte getInicial_Columna()
    {
        return ini_col;
    }

    public sbyte getFinal_Fila()
    {
        return fi_fil;
    }

    public sbyte getFinal_Columna()
    {
        return fi_col;
    }

    public sbyte getCorOCapt()
    {
        return corOCapt;
    }

    public sbyte getFigMou()
    {
        return figMou;
    }

    public void setInicial(sbyte fila, sbyte column)
    {
        ini_fil = fila;
        ini_col = column;

    }
    public void setFinal(sbyte fila, sbyte column)
    {
        fi_fil = fila;
        fi_col = column;
    }

    public void setCorOCapt(sbyte corOCapt)
    {
        this.corOCapt = corOCapt;
    }

    public void setFigMou(sbyte figura)
    {
        figMou = figura;
    }

}
