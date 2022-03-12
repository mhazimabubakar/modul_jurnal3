using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204092
{
    public class Program
    {
        static void Main(string[] args)
        {
            KodeBuah KB1 = new KodeBuah();

            KodeBuah.Buah inputBuah = KodeBuah.Buah.Anggur;

            Console.WriteLine("Kode Buah: " + KB1.getKodeBuah(inputBuah));
            Console.WriteLine();

            PosisiKarakterGame objGame = new PosisiKarakterGame();
            Console.WriteLine("State awal karakter game: " + objGame.StateSaatIni);
            Console.WriteLine();

            objGame.MelakukanAksi(PosisiKarakterGame.Aksi.TombolW);
            Console.WriteLine();
            objGame.MelakukanAksi(PosisiKarakterGame.Aksi.TombolS);
            Console.WriteLine();
            objGame.MelakukanAksi(PosisiKarakterGame.Aksi.TombolS);
            Console.WriteLine();
            objGame.MelakukanAksi(PosisiKarakterGame.Aksi.TombolS);
            Console.WriteLine();
        }
    }
}
