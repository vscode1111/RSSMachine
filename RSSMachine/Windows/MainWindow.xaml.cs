﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSSMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rssController = new RSSController("COM7", true);
        }

        /// <summary>
        /// RSS-контроллер.
        /// </summary>
        RSSController rssController;

        /// <summary>
        /// Стартовый вид.
        /// </summary>
        StartView startView;

        /// <summary>
        /// Вид соглашения.
        /// </summary>
        AgreementView agreementView;

        /// <summary>
        /// Вид тестирования устройста.
        /// </summary>
        TestDeviceView testDeviceView;

        /// <summary>
        /// Вид окна ожидания.
        /// </summary>
        WaitView waitView;

        /// <summary>
        /// Вид окна выбора товара.
        /// </summary>
        SelectProductView selectProductView;

        /// <summary>
        /// Последний активный вид.
        /// </summary>
        ViewBase viewLastVisible;

        /// <summary>
        /// Активизации определенного вида.
        /// </summary>
        T ActivateView<T>(ViewBase view, EventHandler initCallback) where T : ViewBase, new()
        {
            if (viewLastVisible != null)
                viewLastVisible.Visibility = Visibility.Hidden;

            if (view == null)
            {
                view = new T();

                if (initCallback != null)
                    initCallback(view, EventArgs.Empty);
            }

            if (LayoutRoot.Children.Contains(view))
                view.Visibility = Visibility.Visible;
            else
                LayoutRoot.Children.Add(view);

            viewLastVisible = view;
            return (T)view;
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Title += $" {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";

            StartViewCall();

            InfoWindow info = new InfoWindow(typeof(TestDeviceView));
            info.Initializing += (s, a) =>
            {
                ((TestDeviceView)s).PostConstructor(rssController);
            };
            info.Show();
        }

        #region Call views

        private void StartViewCall()
        {
            startView = ActivateView<StartView>(startView,
                (s, a) =>
                {
                    ((StartView)s).PostConstructor(rssController);
                    ((StartView)s).PressButtonClicked += StartView_PressButtonClicked;
                }
            );
        }

        private void AgreementViewCall()
        {
            agreementView = ActivateView<AgreementView>(agreementView,
                (s, a) =>
                {
                    ((AgreementView)s).PostConstructor(rssController);
                    ((AgreementView)s).ContinueButtonClicked += AgreementView_ContinueButtonClicked;
                }
            );
        }

        private void TestDeviceViewCall()
        {
            testDeviceView = ActivateView<TestDeviceView>(testDeviceView,
                (s, a) =>
                {
                    ((TestDeviceView)s).PostConstructor(rssController);
                }
            );
        }

        private void WaitViewCall()
        {
            waitView = ActivateView<WaitView>(waitView,
                (s, a) =>
                {
                    ((WaitView)s).PostConstructor(rssController);
                    ((WaitView)s).SetText("Ожидайте подтверждения от кассира...");
                }
            );
        }
        private void SelectProductViewCall()
        {
            selectProductView = ActivateView<SelectProductView>(selectProductView,
                (s, a) =>
                {
                    ((SelectProductView)s).PostConstructor(rssController);
                }
            );
        }        
        
        #endregion

        private void StartView_PressButtonClicked(object sender, EventArgs e)
        {
            AgreementViewCall();
        }

        /// <summary>
        /// Ожидание подтверждения от кассира.
        /// </summary>
        private async void WaitAnswer()
        {
            try
            {
                await rssController.Beep();
                await rssController.WaitControlStatusChanged();
            }
            catch (Exception ex)
            {

            }

            if (rssController.ControlStatus.btnDeny)
                this.Dispatcher.Invoke(StartViewCall);
            else
            {
                if (rssController.ControlStatus.btnAllow)
                    this.Dispatcher.Invoke(SelectProductViewCall);
            }
        }

        private void AgreementView_ContinueButtonClicked(object sender, EventArgs e)
        {
            WaitViewCall();

            Task taskWait = new Task(WaitAnswer);
            taskWait.Start();
        }

        private void MainWindow1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
