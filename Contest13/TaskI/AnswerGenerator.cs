using System;

public class AnswerGenerator
{
    private static readonly Random Random = new Random(512);

    public static void GenerateAnswer(Task task)
    {
        if (task is TextTask textTask)
        {
            textTask.HardLvl = (Random.Next(1, 10) * textTask.GroupNumber) >> 2;
            textTask.Answer = GenerateAnswer((textTask.Question.Length / 4 ^ 13) + (int) textTask.Type);
        }
        else
        {
            var programingTask = task as ProgramingTask;
            programingTask.HardLvl = (Random.Next(1, 10) * task.GroupNumber) & 19;
            programingTask.Answer =
                GenerateAnswer(programingTask.MaxLinesOfCode / 7 * programingTask.Language.Length / 9 ^ 15 * 3);
        }
    }

    private static string GenerateAnswer(int length)
    {
        string answer = string.Empty;
        for (int i = 0; i < length; i++)
        {
            answer += (char) Random.Next('a', 'z' + 1);
        }

        return answer;
    }
}