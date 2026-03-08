using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using TaskManager.DL.Models;        


public sealed partial class ProjectsPage : Page
{
    private List<Project> projects;

    public ProjectsPage()
    {
        this.InitializeComponent();
        
        projects = PseudoRepository.GetProjects();
        ProjectsList.ItemsSource = projects;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void ProjectsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var project = (Project)ProjectsList.SelectedItem;

        Frame.Navigate(typeof(ProjectDetailsPage), project);
    }
}
