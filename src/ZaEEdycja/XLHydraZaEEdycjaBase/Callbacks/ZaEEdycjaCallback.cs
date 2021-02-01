#region using

using System;
using System.Windows.Forms;
using Hydra;

#endregion

[assembly: CallbackAssemblyDescription(
    "Stany zalegające w oknie Element zamówienia.",
    "Stany zalegające w oknie Element zamówienia, dodatek do importu w dla programu XL.",
    "ISK Sp Z o.o. [piotr.paul@isk.com.pl] [paul.piotr@gmail.com]",
    "1.0",
    "2019.3.0.0",
    "25-01-2021")]

namespace ZaEEdycja.XLHydraZaEEdycjaBase.Callbacks
{
    [SubscribeProcedure(Procedures.ZaEEdycja, "Stany zalegające w oknie Element zamówienia.")]
    public class ZaEEdycjaCallback : Callback
    {
        public override void Init()
        {
            try
            {
                AddSubscription(true, 0, Events.JustAfterWindowOpening,
                    new XLHydraZaEEdycjaChild.Callbacks.ZaEEdycjaCallback(this).JustAfterWindowOpening);
                AddSubscription(false, 0, Events.OpenWindow,
                    new XLHydraZaEEdycjaChild.Callbacks.ZaEEdycjaCallback(this).OnOpenWindow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Cleanup()
        {
        }
    }
}
