using YeminusSoftware.Util;

namespace YeminusSoftware.Application.Helpers
{
    public class Helpers : IHelpers
    {

        public string Desencriptar(string frase, int clave)
        {
            var alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    
            const int size = 27;
            var sizeFrase = frase.Length;
    
            var fraseDesencriptada = "";

            for (var i = 0; i < size + clave + 1; i++)
                alpha.Add(alpha[i]);
    
            for (var i = 0; i < sizeFrase; i++)
            {
                if(size > clave)
                    fraseDesencriptada += alpha[alpha.IndexOf(frase[i]) + size - clave];   
                else
                    fraseDesencriptada += alpha[alpha.IndexOf(frase[i]) + clave - size];
        
            }
    
            return fraseDesencriptada;
        }
        
        public string Encriptar(string frase, int clave)
        {
            var alpha = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };    
    
            for (var i = 0; i < clave; i++)
                alpha.Add(alpha[i]);
            var fraseEncriptada = "";
    
            var sizeFrase = frase.Length;

            for (var i = 0; i < sizeFrase; i++)
                fraseEncriptada += alpha[alpha.IndexOf(frase[i]) + clave];
            return fraseEncriptada;
            
            
        }
    }
}
