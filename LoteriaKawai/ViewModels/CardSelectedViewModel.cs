using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using LoteriaKawai.WeakReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaKawai.ViewModels
{
    public partial class CardSelectedViewModel : ObservableObject
    {
        #region PROPERTIES
        [ObservableProperty]
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


        [ObservableProperty]
        private bool _f1b;
        [ObservableProperty]
        private bool _f2b;
        [ObservableProperty]
        private bool _f3b;
        [ObservableProperty]
        private bool _f4b;
        [ObservableProperty]
        private bool _f5b; 
        [ObservableProperty]
        private bool _f6b;
        [ObservableProperty]
        private bool _f7b;
        [ObservableProperty]
        private bool _f8b;
        [ObservableProperty]
        private bool _f9b;
        [ObservableProperty]
        private bool _f10b;
        [ObservableProperty]
        private bool _f11b;
        [ObservableProperty]
        private bool _f12b;
        [ObservableProperty]
        private bool _f13b;
        [ObservableProperty]
        private bool _f14b;
        [ObservableProperty]
        private bool _f15b;
        [ObservableProperty]
        private bool _f16b;
        #endregion

        [RelayCommand]
        private void BeanChecked(string frame)
        {
            switch(frame)
            {
                case "f1":
                    F1b = !F1b;
                    break;
                case "f2":
                    F2b = !F2b;
                    break;
                case "f3":
                    F3b = !F3b;
                    break;
                case "f4":
                    F4b = !F4b;
                    break;
                case "f5":
                    F5b = !F5b;
                    break;
                case "f6":
                    F6b = !F6b;
                    break;
                case "f7":
                    F7b = !F7b;
                    break;
                case "f8":
                    F8b = !F8b;
                    break;
                case "f9":
                    F9b = !F9b;
                    break;
                case "f10":
                    F10b = !F10b;
                    break;
                case "f11":
                    F11b = !F11b;
                    break;
                case "f12":
                    F12b = !F12b;
                    break;
                case "f13":
                    F13b = !F13b;
                    break;
                case "f14":
                    F14b = !F14b;
                    break;
                case "f15":
                    F15b = !F15b;
                    break;
                case "f16":
                    F16b = !F16b;
                    break;
            }

            if(F1b && F2b && F3b && F4b && F5b && F6b && F7b && F8b && F9b && F10b && F11b && F12b && F13b && F14b && F15b && F16b)
            {
                WeakReferenceMessenger.Default.Send(new WeakReferences.Winner());
            }
        }

        [RelayCommand]
        private void RemoveBeans()
        {
            F1b = F2b = F3b = F4b = F5b = F6b = F7b = F8b = F9b = F10b = F11b = F12b = F13b = F14b = F15b = F16b = false;
        }

        public CardSelectedViewModel() {
           
        }

        /// <summary>
        /// Asign items card.
        /// </summary>
        internal void CreateCard()
        {
            
            C1 = Data[0, 0];
            C2 = Data[0, 1];
            C3 = Data[0, 2];
            C4 = Data[0, 3];
            C5 = Data[1, 0];
            C6 = Data[1, 1];
            C7 = Data[1, 2];
            C8 = Data[1, 3];
            C9 = Data[2, 0];
            C10 = Data[2, 1];
            C11 = Data[2, 2];
            C12 = Data[2, 3];
            C13 = Data[3, 0];
            C14 = Data[3, 1];
            C15 = Data[3, 2];
            C16 = Data[3, 3];
        }
    }
}
