using System;
//初始代码从这里开始

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

/*----------------------------------------------------------------------*/
//改进代码从这里开始

// using System;

// // initialize variables - graded assignments 
// int currentAssignments = 5;


// int[] sophiaScores = new int[]{90,86,87,98,100,94,90};
// int[] andrewScores = new int[]{92,89,81,96,90,89};
// int[] emmaScores = new int[]{90,85,87,98,68,89,89,89};
// int[] loganScores = new int[]{90,95,87,88,96,96}; 
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    
// int[] timmyScores = new int[]{90,89,87,91,92,93,93,92,89};

// decimal[] sumScores = new decimal[]{0,0,0,0,0,0,0,0,0};
// decimal[] examScores = new decimal[]{0,0,0,0,0,0,0,0,0};
// // int sophiaSum = 0;
// // int andrewSum = 0;
// // int emmaSum = 0;
// // int loganSum = 0;
// decimal[] studentScore = new decimal[]{0,0,0,0,0,0,0,0,0};
// // decimal sophiaScore;
// // decimal andrewScore;
// // decimal emmaScore;
// // decimal loganScore;
// string[] studentNames = new string[]{"Sophia","Andrew","Emma","Logan","Becky","Chris","Eric","Gregor","Timmy"};
// string[] studentLetterGrade= new string[]{"A","A","A","A","A","A","A","A","A"};
// int[] tempScores = new int[10];
// int[] extraAverageScore = new int[]{0,0,0,0,0,0,0,0,0};

// foreach(string studentName in studentNames)
// {
//     int countExams = 0;
//     int index = 0;
//     int extraScores = 0;
//     if (studentName == "Sophia")
//     {
//         tempScores=sophiaScores;
//     }
//     else if(studentName == "Andrew")
//     {
//         index = 1;
//         tempScores=andrewScores;
//     }
//     else if(studentName == "Emma")
//     {
//         index = 2;
//         tempScores=emmaScores;
//     }
//     else if(studentName == "Logan")
//     {
//         index = 3;
//         tempScores=loganScores;
//     }
//     else if(studentName == "Becky")
//     {
//         index = 4;
//         tempScores=beckyScores;
//     }
//     else if(studentName == "Chris")
//     {
//         index = 5;
//         tempScores=chrisScores;
//     }
//     else if(studentName == "Eric")
//     {
//         index = 6;
//         tempScores=ericScores;
//     }
//     else if(studentName == "Gregor")
//     {
//         index = 7;
//         tempScores=gregorScores;
//     }
//     else
//     {
//         index = 8;
//         tempScores=timmyScores;
//     }

//     foreach (int score in tempScores)
//     {
//         countExams++;
//         if (countExams <= 5)
//         {
//             sumScores[index] += score;
//             examScores[index] = sumScores[index]/5;
//         }
//         else
//         {
//             extraScores += score;
//             sumScores[index] +=(decimal) score / 10;
//             extraAverageScore[index] = extraScores / (countExams - 5);
//         }
//     }
// }

// // sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// // andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// // emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// // loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
// Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
// for(int i=0; i<studentNames.Length; i++)
// {
//     studentScore[i] = sumScores[i] / currentAssignments;
//     if(studentScore[i]>=97)
//     {
//         studentLetterGrade[i] = "A+";
//     }
//     else if(studentScore[i]>=93)
//     {
//         studentLetterGrade[i] = "A";
//     }
//     else if(studentScore[i]>=90)
//     {
//         studentLetterGrade[i] = "A-";
//     }
//     else if(studentScore[i]>=87)
//     {
//         studentLetterGrade[i] = "B+";
//     }
//     else if(studentScore[i]>=83)
//     {
//         studentLetterGrade[i] = "B";
//     }
//     else if(studentScore[i]>=80)
//     {
//         studentLetterGrade[i] = "B-";
//     }
//     else if(studentScore[i]>=77)
//     {
//         studentLetterGrade[i] = "C+";
//     }
//     else if(studentScore[i]>=73)
//     {
//         studentLetterGrade[i] = "C";
//     }
//     else if(studentScore[i]>=70)
//     {
//         studentLetterGrade[i] = "C-";
//     }
//     else if(studentScore[i]>=67)
//     {
//         studentLetterGrade[i] = "D+";
//     }
//     else if(studentScore[i]>=63)
//     {
//         studentLetterGrade[i] = "D";
//     }
//     else if(studentScore[i]>=60)
//     {
//         studentLetterGrade[i] = "D-";
//     }
//     else
//     {
//         studentLetterGrade[i] = "F";
//     }
//     Console.WriteLine($"{studentNames[i]}:\t\t{examScores[i]}\t\t{studentScore[i]}\t{studentLetterGrade[i]}\t{extraAverageScore[i]}({studentScore[i]-examScores[i]} pts)");
// }
// // foreach(int scores in sumScores)
// // {
// //     studentScore[scores] = (decimal)sumScores[scores] / currentAssignments;
// // }
// // sophiaScore = (decimal)sophiaSum / currentAssignments;
// // andrewScore = (decimal)andrewSum / currentAssignments;
// // emmaScore = (decimal)emmaSum / currentAssignments;
// // loganScore = (decimal)loganSum / currentAssignments;


// // Console.WriteLine("Sophia:\t\t" + studentScore[0] + "\tA-");
// // Console.WriteLine("Andrew:\t\t" + studentScore[1] + "\tB+");
// // Console.WriteLine("Emma:\t\t" + studentScore[2] + "\tB");
// // Console.WriteLine("Logan:\t\t" + studentScore[3] + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
// //强制类型转换有助于保留多位小数，提高结果的精确度
