using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IntervalTrainer
{
    public class IntervalTrainer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>A string array, the first index containing the scale (e.g. C# maj, F min), the 2nd index being a representation of the roman numeral the user has to guess, and the 3rd index
        /// being the notes in that chord, separated by commas list of the notes in that chord</returns>
        public static string[] GetRomanNumeralQuestionData()
        {
            // todo: add inversions, sharp/flat degrees, added note, to the options here
            string[] keyNotes = { "C", "G", "D", "A", "E", "B", "Gb", "Db", "Ab", "Eb", "Bb", "F" };
            string[] keyTypes = { "major", "minor" };
            string[] majorNumerals = { "I", "ii", "iii", "IV", "V", "vi", "vii_dim" }; // should I even include I?
            string[] minorNumerals = { "i", "ii_dim", "III", "iv", "V", "VI", "vii_dim" };
            string questionScale;
            string questionNumeral;
            string questionChordNotes = "";
            string questionKeyNote;
            string questionKeyType;
            int scaleDegreeAmount; // how many half steps away the scale degree is from the key
            int keyNoteIndex;
            int rootNoteIndex;
            int chordToneIndex;


            Random rand = new Random();
            questionKeyNote = keyNotes[rand.Next(0, 12)];
            keyNoteIndex = GetNoteIndexFromNote(questionKeyNote);
            //string questionKeyType = keyTypes[rand.Next(0, 1);
            questionKeyType = keyTypes[0]; // we're sticking to major keys for now
            questionScale = questionKeyNote + " " + questionKeyType;
            if (questionKeyType == "major")
            {
                questionNumeral = majorNumerals[rand.Next(0, 7)];
                // now get the notes for this chord
                switch (questionNumeral)
                {
                    case "I":
                        scaleDegreeAmount = 0;
                        // normally you'd set the scaleDegreeAmount here and add it to rootNoteIndex but in this case it's 0, so there's not much point in doing so
                        rootNoteIndex = keyNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("major 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "ii":
                        scaleDegreeAmount = 2;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("minor 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "iii":
                        scaleDegreeAmount = 3;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("major 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "IV":
                        scaleDegreeAmount = 5;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("major 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "V":
                        scaleDegreeAmount = 7;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("major 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "vi":
                        scaleDegreeAmount = 9;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("minor 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    case "vii_dim":
                        scaleDegreeAmount = 11;
                        rootNoteIndex = keyNoteIndex + scaleDegreeAmount;
                        rootNoteIndex = rootNoteIndex > 11 ? rootNoteIndex - 12 : rootNoteIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(rootNoteIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("minor 3rd");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex) + ",";
                        chordToneIndex = rootNoteIndex + GetIntervalAmountFromName("perfect 5th");
                        chordToneIndex = chordToneIndex > 11 ? chordToneIndex - 12 : chordToneIndex;
                        questionChordNotes += GetNoteNameFromNoteIndex(chordToneIndex);
                        break;
                    default:
                        break;
                }
            }
            //else if (questionKeyType == "minor") // leaving this else if here in case we ever want to add fancy stuff like harmonic minor
            else
            {
                questionNumeral = minorNumerals[rand.Next(0, 7)];
                // now get the notes for this chord
                switch (questionNumeral)
                {
                    case "i":
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("questionScale: {0} questionNumeral: {1} questionChordNotes: {2}", questionScale, questionNumeral, questionChordNotes);
            return new string[] { questionScale, questionNumeral, questionChordNotes };
        }
        /// <summary>
        /// Pseudo-randomly selects a note, and an amount by which to increment it by, determines the index of the note that the user has to guess, and then returns those values
        /// </summary>
        /// <returns>Returns an array with three ints, the first int describes the starting note, the second int describes the interval amount, and the third int describes the note that
        /// the user has to guess.</returns>
        public static int[] GetQuestionNotes()
        {
            Random rand = new Random();
            while (true)
            {
                int initialNoteIndex = rand.Next(0, 12);
                int intervalAmount = rand.Next(2, 10);
                if (intervalAmount == 6 || intervalAmount == 8)
                {
                    continue;
                }
                int intervalNoteIndex = initialNoteIndex + intervalAmount;
                if (intervalNoteIndex > 11)
                {
                    intervalNoteIndex = intervalNoteIndex - 12;
                }
                return new int[] { initialNoteIndex, intervalAmount, intervalNoteIndex };
            }
        }
        /// <summary>
        /// Prompts the user for an answer, converts that answer to an int corresponding to one of the 12 notes
        /// </summary>
        /// <returns>An int from 0 to 11 if input was a valid note, -1 if escape character was detected, -2 otherwise</returns>
        public static int GetUserAnswer()
        {
            string userAnswer = Console.ReadLine();
            return GetNoteIndexFromNote(userAnswer);
        }
        /// <summary>
        /// Converts user answer to an int corresponding to one of the 12 notes.
        /// </summary>
        /// <param name="userAnswer"> A string containing the user answer</param>
        /// <returns>An int from 0 to 11 if input was a valid note, -1 if escape character was detected, -2 otherwise</returns>
        public static int GetNoteIndexFromNote(string noteName)
        {
            int noteIndex;
            switch (noteName.ToLower())
            {
                case "a":
                    noteIndex = 0;
                    break;
                case "a#":
                    noteIndex = 1;
                    break;
                case "bb":
                    noteIndex = 1;
                    break;
                case "b":
                    noteIndex = 2;
                    break;
                case "c":
                    noteIndex = 3;
                    break;
                case "c#":
                    noteIndex = 4;
                    break;
                case "db":
                    noteIndex = 4;
                    break;
                case "d":
                    noteIndex = 5;
                    break;
                case "d#":
                    noteIndex = 6;
                    break;
                case "eb":
                    noteIndex = 6;
                    break;
                case "e":
                    noteIndex = 7;
                    break;
                case "f":
                    noteIndex = 8;
                    break;
                case "f#":
                    noteIndex = 9;
                    break;
                case "gb":
                    noteIndex = 9;
                    break;
                case "g":
                    noteIndex = 10;
                    break;
                case "g#":
                    noteIndex = 11;
                    break;
                case "ab":
                    noteIndex = 11;
                    break;
                case "q":
                    noteIndex = -1;
                    break;
                default:
                    noteIndex = -2;
                    break;
            }
            return noteIndex;
        }
        public static int GetIntervalAmountFromName(string intervalName)
        {
            Dictionary<string, int> intervalNameToAmountDictionary = new Dictionary<string, int>()
            {
                { "perfect unison", 1},
                { "major 2nd" , 2 },
                { "minor 3rd" , 3 },
                { "major 3rd" , 4 },
                { "perfect 4th" , 5 },
                { "augmented 4th" , 6 },
                { "diminished 5th" , 6 },
                { "perfect 5th" , 7 },
                { "augmented 5th" , 8 },
                { "diminished 6th" , 8 },
                { "major 6th" , 9 },
                { "minor 7th" , 10 },
                { "major 7th" , 11 },
                { "perfect octave", 12 }
            };
            intervalName = intervalName.ToLower();
            if (!intervalNameToAmountDictionary.ContainsKey(intervalName))
            {
                // I should throw some sort of exception here but I don't want to get sidetracked, so I'll deal with that later!
                Console.WriteLine("Error in GetIntervalAmountFromName: invalid interval name '" + intervalName + "'");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return intervalNameToAmountDictionary[intervalName];
        }
        /// <summary>
        /// Retrieves the name of an interval based on the input value.
        /// </summary>
        /// <param name="intervalAmount">An int describing the interval whose name is to be retrieved</param>
        /// <returns>A string containing the name of the interval which corresponds to the interval amount</returns>
        public static string GetIntervalName(int intervalAmount)
        {
            Dictionary<int, string> intervalAmountToNameDictionary = new Dictionary<int, string>()
            {
                // octave is included here, but the range of intervalAmount isn't set to go that high, change the range in the future maybe?
                { 0 , "Perfect unison" },
                { 2 , "Major 2nd" },
                { 3 , "Minor 3rd" },
                { 4 , "Major 3rd" },
                { 5 , "Perfect 4th" },
                { 6 , "Augmented 4th / Diminished 5th" },
                { 7 , "Perfect 5th" },
                { 8 , "Augmented 5th / Diminished 6th" },
                { 9 , "Major 6th" },
                { 10, "Minor 7th" },
                { 11, "Major 7th" },
                { 12, "Perfect octave" }
            };
            return intervalAmountToNameDictionary[intervalAmount];
        }
        /// <summary>
        /// Retrieves a note name based on the input number.
        /// </summary>
        /// <param name="index">The index of the note to retrieve</param>
        /// <returns>A string containing a note name</returns>
        public static string GetNoteNameFromNoteIndex(int index)
        {
            try
            {
                string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
                return notes[index];

            }
            catch (Exception e)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = new StackFrame();
                Console.WriteLine(e.ToString());
                Console.WriteLine(st.GetFrame(1).GetMethod().Name);
                Console.WriteLine("aaaargh {0}", sf.GetFileLineNumber());
                return null;
            }
        }
        /// <summary>
        /// Controls the flow of the program, runs the question loop.
        /// </summary>
        /// 
        /*
        public static void main()
        {
            int[] questionArray;
            int initialNoteIndex;
            int userAnswerIndex = 0;
            int intervalNoteIndex;
            string userAnswer;
            string intervalName;
            string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
            var intervalDictionary = new Dictionary<int, string>()
            {
            // Excluding the following intervals for the sake of simplicity:
            // 6 , "augmented 4th / diminished 5th"
            // 8 , "augmented 5th / diminished 6th"
            // also excluding the octave, change the range of intervalAmount if you want to do that!
            { 2 , "Major 2nd"},
            { 3 , "Minor 3rd"},
            { 4 , "Major 3rd"},
            { 5 , "Perfect 4th"},
            { 7 , "Perfect 5th"},
            { 9 , "Major 6th"},
            { 10, "Minor 7th"},
            { 11, "Major 7th"}
            };
            Console.WriteLine("Welcome to the interval trainer! Respond to each question with the appropriate note, press q to quit!");
            while(userAnswerIndex != -1)
            {
                questionArray = GetNotes();
                intervalName = intervalDictionary[questionArray[1]];
                initialNoteIndex = questionArray[0];
                intervalNoteIndex = questionArray[2];
                Console.WriteLine("What is the {0} of {1}?", intervalName, notes[initialNoteIndex]);
                userAnswer = Console.ReadLine();
                userAnswerIndex = ConvertUserAnswer(userAnswer);
                while (true)
                {
                    if (userAnswerIndex == intervalNoteIndex)
                    {
                        Console.WriteLine("Correct! The {0} of {1} is {2}\n", intervalName, notes[initialNoteIndex], notes[intervalNoteIndex]);
                        break;
                    }
                    else if (userAnswerIndex == -1)
                    {
                        break;
                    }
                    else if (userAnswerIndex == -2)
                    {
                        Console.WriteLine("Invalid answer, please try again! If you are trying to quit, please press 'q' and press enter!\n");
                        Console.WriteLine("What is the {0} of {1}?", intervalName, notes[initialNoteIndex]);
                        userAnswer = Console.ReadLine();
                        userAnswerIndex = ConvertUserAnswer(userAnswer);
                    }
                    else
                    {
                        Console.WriteLine("Not quite! Please try again!\n");
                        Console.WriteLine("What is the {0} of {1}?", intervalName, notes[initialNoteIndex]);
                        userAnswer = Console.ReadLine();
                        userAnswerIndex = ConvertUserAnswer(userAnswer);
                        continue;
                    }
                }
            }
            Console.WriteLine("Thank you for playing!");
        }
        */
    }
}
