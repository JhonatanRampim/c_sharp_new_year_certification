using System;

// initialize variables - graded assignments 
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };


Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    decimal overallStudentGrade = 0;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScore = 0;
    int sumTotalCredits = 0;

    decimal examScore = 0;
    decimal totalCredits = 0;
    decimal currentStudentExtraCreditScore = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumExamScore += score;
        }
        else
        {
            gradedExtraCreditAssignments++;
            sumTotalCredits += score;
        }

    }

    overallStudentGrade = (sumExamScore + ((decimal)sumTotalCredits / 10)) / examAssignments;

    examScore = (decimal)sumExamScore / examAssignments;
    totalCredits = (decimal)(sumTotalCredits * 0.1) / examAssignments;
    currentStudentExtraCreditScore = (decimal)sumTotalCredits / gradedExtraCreditAssignments;

    if (overallStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (overallStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (overallStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (overallStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (overallStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (overallStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (overallStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (overallStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (overallStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (overallStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (overallStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (overallStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";



    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{overallStudentGrade}\t{currentStudentLetterGrade}\t\t{currentStudentExtraCreditScore} ({totalCredits} pts)");

}


// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
