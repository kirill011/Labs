using System;
using System.Collections.Generic;
using System.Linq;
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
using StressTest;

namespace Gaz.Lab6.Ex1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Material[] materialsList = (Material[])System.Enum.GetValues(typeof(Material));
            for (int i = 0; i < materialsList.Length; i++)
            { 
                materials.Items.Add(materialsList[i]); 
            }
            CrossSelection[] crossSectionList = (CrossSelection[])System.Enum.GetValues(typeof(CrossSelection));
            for (int i = 0; i < crossSectionList.Length; i++)
            {
                crossSeletions.Items.Add(crossSectionList[i]);
            }

            TestResult[] testResultsList = (TestResult[])System.Enum.GetValues(typeof(TestResult));
            for (int i = 0; i < testResultsList.Length; i++)
                {
                testResults.Items.Add(testResultsList[i]);
            }
            materials.SelectedIndex = 0;
            crossSeletions.SelectedIndex = 0;
            testResults.SelectedIndex = 0;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (materials.SelectedIndex == -1 || crossSeletions.SelectedIndex == -1 || testResults.SelectedIndex == -1) return;
            Material selectedMaterial = (Material)materials.SelectedItem;
            CrossSelection selectedCrossSelection = (CrossSelection)crossSeletions.SelectedItem;
            TestResult selectedTestResult = (TestResult)testResults.SelectedItem;
            StringBuilder selectionStringBuilder = new StringBuilder();
            switch(selectedMaterial)
            {
                case Material.StainlessSteel:
                    selectionStringBuilder.Append("Material: StainlessSteel, ");
                    break;
                case Material.Aluminum:
                    selectionStringBuilder.Append("Material: Aluminum, ");
                    break ;
                case Material.ReinforcedConcrete:
                    selectionStringBuilder.Append("Material: Reinforced Concrete, ");
                    break;
                case Material.Composite:
                    selectionStringBuilder.Append("Material: Composite, ");
                    break;
                case Material.Titanium:
                    selectionStringBuilder.Append("Material: Titanium, ");
                    break;
            }
            switch(selectedCrossSelection)
            {
                case CrossSelection.IBeam:
                    selectionStringBuilder.Append("Cross-selection: I-Beam, ");
                    break;
                case CrossSelection.Box:
                    selectionStringBuilder.Append("Cross-selection: Box, ");
                    break;
                case CrossSelection.ZShaped:
                    selectionStringBuilder.Append("Cross-selection: Z-Shaped, ");
                    break;
                case CrossSelection.CShaped:
                    selectionStringBuilder.Append("Cross-selection: C-Shaped, ");
                    break;
            }
            switch(selectedTestResult)
            {
                case TestResult.Pass:
                    selectionStringBuilder.Append("Test result: Pass");
                    break;
                case TestResult.Fail:
                    selectionStringBuilder.Append("Test result: Fail");
                    break;
            }
            testDetal.Content = selectionStringBuilder.ToString();
        }
    }
}
