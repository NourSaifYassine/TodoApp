using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Services;
using TodoApp.PageModels;

namespace TodoApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private BluetoothManager _bluetoothManager;

        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
            _bluetoothManager = new BluetoothManager();
        }

        private async void OnShareTasksButtonClicked(object sender, EventArgs e)
        {
            var tasks = new List<TodoApp.Models.Task> // Gebruik volledig gekwalificeerde naam
            {
                new Models.Task { Title = "Boodschappen doen", Description = "Koop melk en eieren", DueDate = DateTime.Now.AddDays(1) },
                new Models.Task { Title = "Vergadering", Description = "Teamvergadering om 10:00", DueDate = DateTime.Now.AddDays(2) }
            };

            await _bluetoothManager.ExportTasksAndSendAsync(tasks);
        }
    }
}
