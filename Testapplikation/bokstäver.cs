namespace Testapplikation
{
    public class bokstäver
    {
        public int antalVokaler(string inmat)
        {
            int x = 0;
            int i = 0;
            foreach (char z in inmat)
            {
               switch(z)
                {
                    case 'a':
                        i++;
                        break;
                    case 'e':
                        i++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        i++;
                        break;
                    case 'u':
                        i++;
                        break;
                    case 'y':
                        i++;
                        break;
                    case 'å':
                        i++;
                        break;
                    case 'ä':
                        i++;
                        break;
                    case 'ö':
                        i++;
                        break;
                }

            }
            return i;
        }

        public string omvändOrdning(string inmat)
        {
            string x ="";
            for (int i = inmat.Length-1; i>-1; i--)
            {
                x += inmat[i].ToString();
            }
            return x;
        }

        public string slumpaBokstäver(string inmat)
        {
            Random r = new Random();
            List<char> bokstav = new List<char>();
            int y = 0;
            string x = "";
            foreach (char c in inmat)
            {
                bokstav.Add(c);
            }
            for (int i=0; i < inmat.Length-1; i++)
            {
                y = r.Next(bokstav.Count);
                x += bokstav[y].ToString();
                bokstav.RemoveAt(y);

            }
            return x;
        }
    }
}