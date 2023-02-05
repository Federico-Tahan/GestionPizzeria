using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Encriptacion
    {
        public string Encriptar(string constraseña)
        {
            string h = "PizzeriaFormaggiolasmejoresdelplaneta";
            byte[] datos = UTF8Encoding.UTF8.GetBytes(constraseña);

            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(h));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] resultado = transform.TransformFinalBlock(datos, 0, datos.Length);

            return Convert.ToBase64String(resultado);
        }

        public string Desencriptar(string contraseñaEn)
        {
            string h = "PizzeriaFormaggiolasmejoresdelplaneta";
            byte[] datos = Convert.FromBase64String(contraseñaEn);

            MD5 mD5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = mD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(h));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] resultado = transform.TransformFinalBlock(datos, 0, datos.Length);

            return UTF8Encoding.UTF8.GetString(resultado);
        }

    }
}