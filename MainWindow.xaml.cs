using IntervalTrainer;
using System;
using System.Windows;
using System.Windows.Input;

namespace IntervalTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int[] questionArray;
        private static string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        /// <summary>
        /// Initializes the window, runs the first question.
        /// </summary>
        public MainWindow()
        {

            IntervalTrainer.GetRomanNumeralQuestionData();
            InitializeComponent();
            PoseNoteGuessQuestion();
        }
        /// <summary>
        /// Retrieves a new set of notes for the question, and displays the question
        /// </summary>
        private void PoseNoteGuessQuestion()
        {
            questionArray = IntervalTrainer.GetQuestionNotes();
            questionPrompt.Text = "What is the " + IntervalTrainer.GetIntervalName(questionArray[1]).ToLower() + " of " + notes[questionArray[0]] + "?";
        }
        private void PoseIntervalGuessQuestion()
        {
            questionArray = IntervalTrainer.GetQuestionNotes();
            questionPrompt.Text = "What is the interval between " + notes[questionArray[0]] + " and " + notes[questionArray[2]] + "?";
        }
        private void PoseRomanNumeralGuessQuestion()
        {

        }
        /// <summary>
        /// Checks if the user's answer is correct. If it is, the display is updated accordingly and the next question is loaded. If not, the display is updated and the user can attempt another answer.
        /// </summary>
        private void CheckUserNoteGuess()
        {
            int userAnswerIndex = IntervalTrainer.GetNoteIndexFromNote(userNoteGuess.Text);
            if (questionArray[2] == userAnswerIndex)
            {
                userGuessResult.Text = "That's right! the " + IntervalTrainer.GetIntervalName(questionArray[1]).ToLower() + " of " + notes[questionArray[0]] + " is " + userNoteGuess.Text + "!";
                PoseNoteGuessQuestion();
            }
            else
            {
                userGuessResult.Text = "Not quite, try again!";
            }
        }
        /// <summary>
        /// Checks if the user's answer is correct. If it is, the display is updated accordingly and the next question is loaded. If not, this display is updated and the user can attempt another answer.
        /// </summary>
        private void CheckUserIntervalGuess()
        {
            int userIntervalResponse;
            switch (intervalDropDown.Text)
            {
                case "Major 2nd":
                    userIntervalResponse = 2;
                    break;
                case "Minor 3rd":
                    userIntervalResponse = 3;
                    break;
                case "Major 3rd":
                    userIntervalResponse = 4;
                    break;
                case "Perfect 4th":
                    userIntervalResponse = 5;
                    break;
                case "Perfect 5th":
                    userIntervalResponse = 7;
                    break;
                case "Major 6th":
                    userIntervalResponse = 9;
                    break;
                case "Minor 7th":
                    userIntervalResponse = 10;
                    break;
                case "Major 7th":
                    userIntervalResponse = 11;
                    break;
                default:
                    return;
            }
            if (userIntervalResponse == questionArray[1])
            {
                userGuessResult.Text = "That's right! The interval between " + notes[questionArray[0]] + " and " + notes[questionArray[2]] + " is a " + intervalDropDown.Text.ToLower() + "!";
                PoseIntervalGuessQuestion();
            }
            else
            {
                userGuessResult.Text = "Not quite, try again!";
            }
        }
        private void RomanNumeralMode_Click(object sender, RoutedEventArgs e)
        {
            userNoteGuess.Visibility = Visibility.Hidden;
            submitNoteGuessButton.Visibility = Visibility.Hidden;


        }
        /// <summary>
        /// 
        /// Invokes checkUserIntervalGuess() and clears the dropdown window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitIntervalGuessButton_Click(object sender, RoutedEventArgs e)
        {
            CheckUserIntervalGuess();
            intervalDropDown.Text = "";
        }
        /// <summary>
        /// Invokes checkUserNoteGuess() and clears the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNoteGuessButton_Click(object sender, RoutedEventArgs e)
        {
            CheckUserNoteGuess();
            userNoteGuess.Text = "";
        }
        /// <summary>
        /// Invokes checkUserNoteGuess() and clears the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserNoteGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                CheckUserNoteGuess();
                userNoteGuess.Text = "";
            }
        }
        /// <summary>
        /// Switches to interval guessing mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntervalModeButton_Click(object sender, RoutedEventArgs e)
        {
            userNoteGuess.Visibility = Visibility.Hidden;
            submitNoteGuessButton.Visibility = Visibility.Hidden;
            intervalModeButton.Visibility = Visibility.Hidden;
            intervalDropDown.Visibility = Visibility.Visible;
            submitIntervalGuessButton.Visibility = Visibility.Visible;
            noteModeButton.Visibility = Visibility.Visible;
            userGuessResult.Text = "";
            PoseIntervalGuessQuestion();
        }

        /// <summary>
        /// Switches to note guessing mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteModeButton_Click(object sender, RoutedEventArgs e)
        {
            userNoteGuess.Visibility = Visibility.Visible;
            submitNoteGuessButton.Visibility = Visibility.Visible;
            intervalModeButton.Visibility = Visibility.Visible;
            intervalDropDown.Visibility = Visibility.Hidden;
            submitIntervalGuessButton.Visibility = Visibility.Hidden;
            noteModeButton.Visibility = Visibility.Hidden;
            userGuessResult.Text = "";
            PoseNoteGuessQuestion();
        }
    }
}
/*
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

namespace IntervalTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
*/