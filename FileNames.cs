using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT2EngineSoundEd
{
    public class FileNames
    {
        public static List<SoundFile> mSoundsList = new List<SoundFile>
        {
            new SoundFile(1, "I4, 8000 RPM, DOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(1, "I4, 7000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(2, "I4, 5500 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(2, "V6, 7000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(3, "I4, 8000 RPM, DOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(3, "I4, 9000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(4, "I3, 15000 RPM, tiny, stock muffler", ExhaustType.Stock),
            new SoundFile(4, "I4, 7000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(5, "I4, 5000 RPM, diesel, stock muffler", ExhaustType.Stock),
            new SoundFile(5, "I6, 8000 RPM, DOHC, stock muffler", ExhaustType.n0),
            new SoundFile(5, "I4, 9000 RPM, DOHC, stock muffler", ExhaustType.n1),
            new SoundFile(5, "I4, 9000 RPM, DOHC, sport muffler", ExhaustType.n2),
            new SoundFile(5, "I4, 11000 RPM, DOHC, race muffler", ExhaustType.n3),
            new SoundFile(6, "I4, 5500 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(6, "I4, 8000 RPM, DOHC, stock muffler", ExhaustType.n0),
            new SoundFile(6, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.n1),
            new SoundFile(6, "I4, 10000 RPM, DOHC, semirace muffler", ExhaustType.n2),
            new SoundFile(6, "I4, 11000 RPM, DOHC, race muffler", ExhaustType.n3),
            new SoundFile(7, "I4, 8000 RPM, DOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(7, "I4, 9000 RPM, DOHC, open headers", ExhaustType.t0),
            new SoundFile(8, "I6, 7000 RPM, DOHC, stock exhaust", ExhaustType.Stock),
            new SoundFile(8, "I4, 9000 RPM, DOHC, open headers", ExhaustType.t0),
            new SoundFile(9, "I4, 5500 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(9, "I4, 8000 RPM, DOHC, race muffler", ExhaustType.t0),
            new SoundFile(9, "F6, 8000 RPM, DOHC, sport muffler", ExhaustType.t1),
            new SoundFile(9, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(9, "F6, 8000 RPM, DOHC, semirace muffler", ExhaustType.t3),
            new SoundFile(10, "I4, 5500 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(10, "I4, 8000 RPM, DOHC, stock muffler", ExhaustType.n0),
            new SoundFile(10, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.n1),
            new SoundFile(10, "I4, 8000 RPM, DOHC, race muffler", ExhaustType.n2),
            new SoundFile(10, "I4, 12000 RPM, DOHC, race muffler", ExhaustType.n3),
            new SoundFile(11, "I4, 5000 RPM, diesel, stock muffler", ExhaustType.Stock),
            new SoundFile(11, "I6, 4000 RPM, diesel, stock muffler", ExhaustType.n0),
            new SoundFile(11, "I6, 5000 RPM, SOHC, stock muffler", ExhaustType.n1),
            new SoundFile(11, "V6, 8000 RPM, DOHC, sport muffler", ExhaustType.n2),
            new SoundFile(11, "I6, 8000 RPM, DOHC, open headers", ExhaustType.n3),
            new SoundFile(11, "I6, 5000 RPM, SOHC, stock muffler", ExhaustType.t0),
            new SoundFile(11, "I6, 5500 RPM, SOHC, stock muffler", ExhaustType.t1),
            new SoundFile(11, "V6, 8000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(11, "I6, 8000 RPM, DOHC, open headers", ExhaustType.t3),
            new SoundFile(12, "I4, 12000 RPM, DOHC, race muffler", ExhaustType.Stock),
            new SoundFile(12, "I4, 9000 RPM, DOHC, sport muffler", ExhaustType.n0),
            new SoundFile(12, "F6, 8000 RPM, DOHC, semirace muffler", ExhaustType.n1),
            new SoundFile(12, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.n2),
            new SoundFile(12, "F6, 7000 RPM, DOHC, race muffler", ExhaustType.n3),
            new SoundFile(12, "I4, 8000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(12, "F6, 7000 RPM, DOHC, stock muffler", ExhaustType.t1),
            new SoundFile(12, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(12, "F6, 7000 RPM, DOHC, sport muffler", ExhaustType.t3),
            new SoundFile(13, "V6, 6000 RPM, DOHC, sport muffler", ExhaustType.Stock),
            new SoundFile(13, "I4, 7000 RPM, DOHC, sport muffler", ExhaustType.n0),
            new SoundFile(14, "I4, 5000 RPM, diesel, stock muffler", ExhaustType.Stock),
            new SoundFile(14, "I4, 5000 RPM, diesel, sport muffler", ExhaustType.t0),
            new SoundFile(14, "I4, 7000 RPM, DOHC, sport muffler", ExhaustType.t1),
            new SoundFile(14, "V6, 7000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(14, "I6, 5000 RPM, DOHC, stock muffler", ExhaustType.t3),
            new SoundFile(15, "I4, 6000 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(15, "V8, 3000 RPM, diesel, stock muffler", ExhaustType.t0),
            new SoundFile(16, "I4, 4000 RPM, diesel, stock muffler", ExhaustType.Stock),
            new SoundFile(16, "V6, 5000 RPM, SOHC, sport muffler", ExhaustType.n0),
            new SoundFile(17, "V6, 6000 RPM, DOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(17, "V6, 6000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(17, "V6, 5000 RPM, DOHC, sport muffler", ExhaustType.t1),
            new SoundFile(17, "I4, 8000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(17, "F4, 9000 RPM, DOHC, race muffler", ExhaustType.t3),
            new SoundFile(18, "I4, 6000 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(18, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(18, "I4, 7000 RPM, SOHC, sport muffler", ExhaustType.t1),
            new SoundFile(18, "I4, 7000 RPM, SOHC, semirace muffler", ExhaustType.t2),
            new SoundFile(18, "I4, 9000 RPM, DOHC, race muffler", ExhaustType.t3),
            new SoundFile(18, "I4, 8000 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(18, "I4, 10000 RPM, DOHC, stock muffler", ExhaustType.t0),
            new SoundFile(18, "I4, 9000 RPM, SOHC, sport muffler", ExhaustType.t1),
            new SoundFile(18, "I4, 8000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(18, "I4, 9000 RPM, DOHC, sport muffler", ExhaustType.t3),
            new SoundFile(19, "I4, 8000 RPM, SOHC, stock muffler", ExhaustType.Stock),
            new SoundFile(19, "I4, 8000 RPM, SOHC, sport muffler", ExhaustType.t0),
            new SoundFile(19, "I4, 8000 RPM, SOHC, semirace muffler", ExhaustType.t1),
            new SoundFile(19, "I4, 8000 RPM, SOHC, race muffler", ExhaustType.t2),
            new SoundFile(19, "I4, 9000 RPM, DOHC, semirace muffler", ExhaustType.t3),
            new SoundFile(20, "I4, 8000 RPM, SOHC, sport muffler", ExhaustType.Stock),
            new SoundFile(20, "I4, 10000 RPM, DOHC, sport muffler", ExhaustType.t0),
            new SoundFile(20, "I4, 10000 RPM, DOHC, semirace muffler", ExhaustType.t1),
            new SoundFile(20, "F4, 7000 RPM, DOHC, sport muffler", ExhaustType.t2),
            new SoundFile(20, "F4, 7000 RPM, DOHC, semirace muffler", ExhaustType.t3),

        };

        public static Dictionary<int, string> mCarNames = new Dictionary<int, string>
        {
            { 1, "Toyota Corolla Rally Car" },
            { 2, "Peugeot 206 Rally Car" },
            { 3, "Ford Focus Rally Car"},
            { 4, "Subaru Impreza WRC 97 + Impreza WRC '99 + Suzuki Cultus Pike's Peak"},
            { 5, "Lexus GS400 + SC400" },
            { 6, "Toyota Starlet 3door Turbo S '82"},
            { 7, "Toyota Celica WedsSport GT + MR2 Momo Corse GT + BP Apex Kraft Trueno GT + Altezza LM"},
            { 8, "Toyota Supra JGTC" },
            { 9, "???" },
            { 10, "Mazda Demio A-spec" },

        };
    }

    public class SoundFile
    {
        public int SoundId = -1;
        public string Description = string.Empty;
        public ExhaustType ExhaustType;

        public SoundFile(int soundId, string description, ExhaustType exhaustType)
        {
            SoundId = soundId;
            Description = description;
            ExhaustType = exhaustType;
        }
    }

    public enum ExhaustType
    {
        Stock,
        n0,
        n1,
        n2,
        n3,
        t0,
        t1,
        t2,
        t3,
    }
}
