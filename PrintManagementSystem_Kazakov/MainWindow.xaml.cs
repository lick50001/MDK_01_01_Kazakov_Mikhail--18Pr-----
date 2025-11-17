using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PrintManagementSystem_Kazakov.Classes;

namespace PrintManagementSystem_Kazakov
{
    public partial class MainWindow : Window
    {
        public List<TypeOpertation> typeOperationList = TypeOpertation.AllTypeOperation;
        public List<Format> formatsList = Format.AllFormats();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (TypeOperation items in typeOperationList)
            {
                typeOperation.Items.Add(items.name);
            }
            foreach (Format format in formatsList)
            {
                formats.Items.Add(format);
            }
        }

        public void CostCalculations()
        {
            float price = 0;

            if (typeOperation.SelectedIndex != -1)
            {
                if (typeOperation.SelectedItem as String == "Сканирование") price = 10;
                else if (typeOperation.SelectedItem as String == "Печать" || typeOperation.SelectedItem as String == "Копия")
                {
                    if (formats.SelectedItem as String == "A4")
                    {

                    }
                }
            }
        }

        private void DeleteOperation(object sender, RoutedEventArgs e)
        {

        }

        private void EditOperation(object sender, RoutedEventArgs e)
        {

        }

        private void SelectedType(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelectedFormat(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBoxCount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {

        }

        private void ColorsChange(object sender, RoutedEventArgs e)
        {

        }
    }
}