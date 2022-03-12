using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204092
{
    public class PosisiKarakterGame
    {
        public enum Status
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap
        };

        public enum Aksi
        {
            TombolW,
            TombolS,
            TombolX
        };

        public class Transisi
        {
            public Status StateAwal;
            public Status StateAkhir;
            public Aksi Trigger;

            public Transisi(Status awal, Status akhir, Aksi melakukan)
            {
                StateAwal = awal; StateAkhir = akhir; Trigger = melakukan;
            }
        }

        Transisi[] listPerpindahanState =
        {
            new Transisi(Status.Berdiri,Status.Terbang,Aksi.TombolW),
            new Transisi(Status.Berdiri, Status.Jongkok,Aksi.TombolS),
            new Transisi(Status.Terbang,Status.Berdiri,Aksi.TombolS),
            new Transisi(Status.Terbang,Status.Jongkok,Aksi.TombolX),
            new Transisi(Status.Jongkok,Status.Berdiri,Aksi.TombolW),
            new Transisi(Status.Jongkok,Status.Tengkurap,Aksi.TombolS),
            new Transisi(Status.Tengkurap,Status.Jongkok,Aksi.TombolW)
        };

        public Status StateSaatIni = Status.Berdiri;

        public Status getStatusAkhir(Status awal,Aksi melakukan)
        {
            Status statusAkhir = awal;

            for (int i = 0; i < listPerpindahanState.Length; i++)
            {
                Status stateAwal = listPerpindahanState[i].StateAwal;
                Aksi triggerState = listPerpindahanState[i].Trigger;

                if (stateAwal == awal && triggerState == melakukan)
                {
                    statusAkhir = listPerpindahanState[i].StateAkhir;
                }
            }
            return statusAkhir;
        }

        public void MelakukanAksi(Aksi melakukan)
        {
            Status stateBerikutnya = getStatusAkhir(StateSaatIni, melakukan);
            StateSaatIni = stateBerikutnya;

            Console.WriteLine("State saat ini: " + StateSaatIni);

            if (StateSaatIni == Status.Jongkok)
            {
                Console.WriteLine("posisi landing");
            }
            else if (StateSaatIni == Status.Terbang)
            {
                Console.WriteLine("posisi take off");
            }
        }

        public PosisiKarakterGame()
        {
            StateSaatIni = Status.Berdiri;
        }
    }
}
