using TuringTests.Classes;

PracticeTest();



static void PracticeTest()
{
    Solution solution = new Solution();
    char[] space = new char[] { ' ' };

    string input1 = "5 2 C D +"; // 30
    string input2 = "5 -2 4 C D 9 + +"; // 27
    string input3 = "1"; // 1
    string input4 = "12 13 C D + + D"; // 252
    string[] ops = input1.Split(space);

    int output = solution.CalPoints(ops);
    System.Console.WriteLine(output);
}
