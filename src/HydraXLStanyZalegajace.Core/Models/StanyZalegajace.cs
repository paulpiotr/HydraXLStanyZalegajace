#region using

using System.ComponentModel.DataAnnotations;

#endregion

namespace HydraXLStanyZalegajace.Core.Models
{
    public class StanyZalegajace
    {
        //Twr_Nazwa int,
        private string _twrNazwa;

        //Twr_Kod int,
        private string _twrKod;

        //TwZ_IlDok decimal (15,4),
        private decimal _twZIlDok;

        //TwZ_MagKod varchar(10),
        private string _twZMagKod;

        //TwZ_MagNumer int,
        private int _twZMagNumer;

        //TwZ_TwrNumer int,
        private int _twZTwrNumer;

        public StanyZalegajace()
        {
        }

        public StanyZalegajace(int twZMagNumer, string twZMagKod, int twZTwrNumer, string twrKod, string twrNazwa,
            decimal twZIlDok)
        {
            _twZMagNumer = twZMagNumer;
            _twZMagKod = twZMagKod;
            _twZTwrNumer = twZTwrNumer;
            _twrKod = twrKod;
            _twrNazwa = twrNazwa;
            _twZIlDok = twZIlDok;
        }

        [Display(Name = "Numer magazynu", Prompt = "Numer magazynu", Description = "Numer magazynu")]
        public int TwZ_MagNumer
        {
            get => _twZMagNumer;
            set
            {
                if (value != _twZMagNumer)
                {
                    _twZMagNumer = value;
                }
            }
        }

        [Display(Name = "Kod magazynu", Prompt = "Kod magazynu", Description = "Kod magazynu")]
        public string TwZ_MagKod
        {
            get => _twZMagKod;
            set
            {
                if (value != _twZMagKod)
                {
                    _twZMagKod = value;
                }
            }
        }

        [Display(Name = "Numer towaru", Prompt = "Numer towaru", Description = "Numer towaru")]
        public int TwZ_TwrNumer
        {
            get => _twZTwrNumer;
            set
            {
                if (value != _twZTwrNumer)
                {
                    _twZTwrNumer = value;
                }
            }
        }

        [Display(Name = "Kod Towaru", Prompt = "Kod Towaru", Description = "Kod Towaru")]
        public string Twr_Kod
        {
            get => _twrKod;
            set
            {
                if (value != _twrKod)
                {
                    _twrKod = value;
                }
            }
        }

        [Display(Name = "Numer Dst", Prompt = "Numer Dst", Description = "Numer Dst")]
        public string Twr_Nazwa
        {
            get => _twrNazwa;
            set
            {
                if (value != _twrNazwa)
                {
                    _twrNazwa = value;
                }
            }
        }

        [Display(Name = "Pole IlSpr", Prompt = "Pole IlSpr", Description = "Pole IlSpr")]
        public decimal TwZ_IlDok
        {
            get => _twZIlDok;
            set
            {
                if (value != _twZIlDok)
                {
                    _twZIlDok = value;
                }
            }
        }
    }
}
