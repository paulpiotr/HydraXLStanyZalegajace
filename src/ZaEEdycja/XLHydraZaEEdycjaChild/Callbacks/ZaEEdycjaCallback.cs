#region using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hydra;
using HydraXLStanyZalegajace.Core.Models;
using HydraXLStanyZalegajace.Core.Repositories;
using HydraXLStanyZalegajace.Forms.Forms;

#endregion

[assembly: CallbackAssemblyDescription(
    "Stany zalegające w oknie Element zamówienia.",
    "Stany zalegające w oknie Element zamówienia, dodatek do załączenia w katalogu głównym programu XL",
    "ISK Sp Z o.o. [piotr.paul@isk.com.pl] [paul.piotr@gmail.com]",
    "1.0",
    "2019.3.0.0",
    "25-01-2021")]

namespace ZaEEdycja.XLHydraZaEEdycjaChild.Callbacks
{
    public class ZaEEdycjaCallback : Callback
    {
        private Callback _parentCallback;

        private BindingList<StanyZalegajace> _stanyZalegajaceBindingList;

        private BindingSource _stanyZalegajaceBindingSource;

        private StanyZalegajaceForm _stanyZalegajaceForm;

        private List<StanyZalegajace> _stanyZalegajaceList = new List<StanyZalegajace>();

        public ZaEEdycjaCallback(Callback callback)
        {
            ParentCallback = callback;
        }

        public List<StanyZalegajace> StanyZalegajaceList
        {
            get => _stanyZalegajaceList;
            set
            {
                if (value != _stanyZalegajaceList)
                {
                    _stanyZalegajaceList = value;
                }
            }
        }

        public BindingList<StanyZalegajace> StanyZalegajaceBindingList
        {
            get => _stanyZalegajaceBindingList;
            set
            {
                if (value != _stanyZalegajaceBindingList)
                {
                    _stanyZalegajaceBindingList = value;
                }
            }
        }

        public BindingSource StanyZalegajaceBindingSource
        {
            get => _stanyZalegajaceBindingSource;
            set
            {
                if (value != _stanyZalegajaceBindingSource)
                {
                    _stanyZalegajaceBindingSource = value;
                }
            }
        }

        public Callback ParentCallback
        {
            get => _parentCallback;
            set
            {
                if (value != _parentCallback)
                {
                    _parentCallback = value;
                }
            }
        }

        public override void Init()
        {
        }

        public override void Cleanup()
        {
        }

        public bool JustAfterWindowOpening(Procedures procId, int controlId, Events @event)
        {
            try
            {
                _stanyZalegajaceForm = null;
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e.Message}");
            }

            return true;
        }

        public bool OnOpenWindow(Procedures procId, int controlId, Events @event)
        {
            _parentCallback.AddSubscription(true, ParentCallback.GetWindow().Children["?Cli_Zapisz"].Id,
                Events.Accepted, StanyZalegajace);
            _parentCallback.AddSubscription(true, ParentCallback.GetWindow().Id,
                Events.CloseWindow, OnAfterCloseWindowOpenStanyZalegajaceFormOpen);
            return true;
        }

        private bool StanyZalegajace(Procedures procId, int controlId, Events @event)
        {
            try
            {
                var cMagazyn = Convert.ToString(ParentCallback.GetWindow().Children["?cMagazyn"].ValueRaw);
                if (null != cMagazyn && !string.IsNullOrWhiteSpace(cMagazyn) && cMagazyn == "SW1")
                {
                    _parentCallback.GetControl(controlId).Enabled = false;
                    _parentCallback.GetControl(controlId).Visible = false;
                    StanyZalegajaceList.Clear();
                    var cKopTwrKodValueRaw =
                        Convert.ToString(ParentCallback.GetWindow().Children["?cKop_Twr:Kod"].ValueRaw);
                    SqlConnection sqlConnection =
                        Runtime.ActiveRuntime.Repository.Connection.CreateCommand().Connection;
                    var twrKartyRepository = new TwrKartyRepository();
                    var twrGidNumer = twrKartyRepository.GetTwrGIDNumerByTwrKod(sqlConnection, cKopTwrKodValueRaw);
                    if (twrKartyRepository.HasException())
                    {
                        MessageBox.Show($@"{twrKartyRepository.TwrKartyRepositoryException.Message}
{twrKartyRepository.TwrKartyRepositoryException.StackTrace}");
                    }

                    if (twrGidNumer > 0)
                    {
                        StanyZalegajaceList =
                            twrKartyRepository.ISKZasobyNierotujaceZSOSStoredProcedure(sqlConnection, twrGidNumer);
                        if (twrKartyRepository.HasException())
                        {
                            MessageBox.Show($@"{twrKartyRepository.TwrKartyRepositoryException.Message}
{twrKartyRepository.TwrKartyRepositoryException.StackTrace}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e.Message}
{e.StackTrace}");
            }

            return true;
        }

        private bool OnAfterCloseWindowOpenStanyZalegajaceFormOpen(Procedures procId, int controlId, Events @event) =>
            StanyZalegajaceWindowShow();

        private bool OnAfterCloseWindowOpenStanyZalegajaceFormClose(Procedures procId, int controlId, Events @event) =>
            true;

        private bool StanyZalegajaceWindowShow()
        {
            try
            {
                if (null == _stanyZalegajaceForm && null != StanyZalegajaceList && StanyZalegajaceList.Count > 0)
                {
                    StanyZalegajaceBindingList = new BindingList<StanyZalegajace>(StanyZalegajaceList);
                    StanyZalegajaceBindingSource = new BindingSource(StanyZalegajaceBindingList, null);
                    _stanyZalegajaceForm = new StanyZalegajaceForm(StanyZalegajaceBindingSource);
                    _stanyZalegajaceForm.Show();
                    _stanyZalegajaceForm.Closed += WindowOnClosed;
                    _stanyZalegajaceForm.Closing += WindowOnClosing;
                    _stanyZalegajaceForm.BringToFront();
                    return false;
                }

                if (null != _stanyZalegajaceForm)
                {
                    _stanyZalegajaceForm.BringToFront();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e.Message}");
            }

            return true;
        }

        private void WindowOnClosing(object sender, CancelEventArgs e)
        {
            try
            {
                _parentCallback.RemoveSubscription(true, _parentCallback.GetWindow().Id, Events.CloseWindow,
                    OnAfterCloseWindowOpenStanyZalegajaceFormOpen);
                _parentCallback.AddSubscription(true, ParentCallback.GetWindow().Id,
                    Events.CloseWindow, OnAfterCloseWindowOpenStanyZalegajaceFormClose);
                _parentCallback.PostEvent(_parentCallback.GetWindow().Id, Events.Refresh);
                _parentCallback.PostEvent(_parentCallback.GetWindow().Id, Events.CloseWindow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{ex.Message} {ex.StackTrace}");
            }
        }

        private void WindowOnClosed(object sender, EventArgs e)
        {
            try
            {
                _parentCallback.RemoveSubscription(true, _parentCallback.GetWindow().Id, Events.CloseWindow,
                    OnAfterCloseWindowOpenStanyZalegajaceFormOpen);
                _parentCallback.AddSubscription(true, ParentCallback.GetWindow().Id,
                    Events.CloseWindow, OnAfterCloseWindowOpenStanyZalegajaceFormClose);
                _parentCallback.PostEvent(_parentCallback.GetWindow().Id, Events.Refresh);
                _parentCallback.PostEvent(_parentCallback.GetWindow().Id, Events.CloseWindow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"{ex.Message}");
            }
        }
    }
}
