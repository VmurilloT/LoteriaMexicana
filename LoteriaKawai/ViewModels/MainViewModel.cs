using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaKawai.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        #region PROPERTIES
        private string[,] data;

        [ObservableProperty]
        private string _c1;
        [ObservableProperty]
        private string _c2;
        [ObservableProperty]
        private string _c3;
        [ObservableProperty]
        private string _c4;
        [ObservableProperty]
        private string _c5;
        [ObservableProperty]
        private string _c6;
        [ObservableProperty]
        private string _c7;
        [ObservableProperty]
        private string _c8;
        [ObservableProperty]
        private string _c9;
        [ObservableProperty]
        private string _c10;
        [ObservableProperty]
        private string _c11;
        [ObservableProperty]
        private string _c12;
        [ObservableProperty]
        private string _c13;
        [ObservableProperty]
        private string _c14;
        [ObservableProperty]
        private string _c15;
        [ObservableProperty]
        private string _c16;

        #endregion


        #region Commands
        [RelayCommand]
        private void CreateNewCard()
        {
            CreateCard();
        }
        [RelayCommand]
        private void SelectedCard()
        {
            WeakReferences.Cards card = new WeakReferences.Cards();
            card.Data = data;
            WeakReferenceMessenger.Default.Send(card);
        }
        #endregion

        /// <summary>
        /// Construtor
        /// </summary>
        public MainViewModel()
        {
            CreateCard();
        }
       
        /// <summary>
        /// Create a new card to gaming
        /// </summary>
        private void CreateCard()
        {
            data = Models.TableModel.getInstance().getTable();
            C1 = data[0, 0];
            C2 = data[0, 1];
            C3 = data[0, 2];
            C4 = data[0, 3];
            C5 = data[1, 0];
            C6 = data[1, 1];
            C7 = data[1, 2];
            C8 = data[1, 3];
            C9 = data[2, 0];
            C10 = data[2, 1];
            C11 = data[2, 2];
            C12 = data[2, 3];
            C13 = data[3, 0];
            C14 = data[3, 1];
            C15 = data[3, 2];
            C16 = data[3, 3];
        }
    }
}
