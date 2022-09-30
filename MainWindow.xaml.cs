using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using wpfInterdisciplinaryAssignment1.Controller;
using wpfInterdisciplinaryAssignment1.Domain;
using wpfInterdisciplinaryAssignment1.Foundation;

namespace wpfInterdisciplinaryAssignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableData ob = new ObservableData();
        KnowledgeBuilder kb = new KnowledgeBuilder();
        Knowledge k;
        BagOfWords bof;
        FileLists fl;
        long trainingTime;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start timer for trainTimeTextBox
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // initiate learning process
            kb.Train();

            // stop timer and set trainTimeTextBox
            timer.Stop();
            trainingTime = timer.ElapsedMilliseconds;
            trainTimeTextBox.Text = "Time: " + trainingTime + " ms";

            // getting whole knowledge found in ClassA and ClassB
            k = kb.GetKnowledge();

            // getting parts of the knowledge
            bof = k.GetBagOfWords();
            fl = k.GetFileLists();

            // updating ob based on gained knowledge
            ob.ObservableA = new ObservableCollection<string>(fl.GetA().Select(StringOperations.getFileName));
            ob.ObservableB = new ObservableCollection<string>(fl.GetB().Select(StringOperations.getFileName));
            ob.ObservableAB = new ObservableCollection<string>(fl.GetBoth().Select(StringOperations.getFileName));
            ob.ObservableDictionaryList = new ObservableCollection<string>(bof.GetEntriesInDictionary());
            ob.ObservableTokens = new ObservableCollection<int>(k.GetTokenCount().Tokens);
        }
    }
}
