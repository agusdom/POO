using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    static class Utiles
    {
        //Método que valida si un campo tiene un tipo de dato correcto
        //Recibimos como parametro el dato y el tipo de dato que queremos validar
        //ejemplo: validarCampo("25","Int");---->retorna true
        public static Boolean validarCampo(String dato,String tipo)
        {
            switch (tipo)
            {
                case "Int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                case "Float":
                    try
                    {
                        Convert.ToSingle(dato);
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                case "String":
                    if (dato.Trim() != "")
                    {
                        try
                        {
                            Convert.ToString(dato);
                            return true;
                        }catch (Exception e)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }
    }
}
