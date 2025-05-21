using System;

class Program
{
    static void Main()
    {
        // Параметры
        int N = 25; // Количество студентов
        int M = 5;  // Количество предметов

        // Создаем двумерный массив оценок (25x5)
        int[,] grades = new int[N, M];

        // Заполняем массив случайными оценками от 1 до 5
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                grades[i, j] = random.Next(1, 6); // Генерация случайного числа от 1 до 5
            }
        }

        // Расчет среднего балла для каждого студента
        double[] studentAverages = new double[N];
        for (int i = 0; i < N; i++)
        {
            double sum = 0;
            for (int j = 0; j < M; j++)
            {
                sum += grades[i, j];
            }
            studentAverages[i] = sum / M;
        }

        // Расчет среднего балла для каждого предмета
        double[] subjectAverages = new double[M];
        for (int j = 0; j < M; j++)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += grades[i, j];
            }
            subjectAverages[j] = sum / N;
        }

        // Нахождение максимального и минимального средних баллов среди студентов
        double maxStudentAverage = studentAverages.Max();
        double minStudentAverage = studentAverages.Min();
        int maxStudentIndex = Array.IndexOf(studentAverages, maxStudentAverage);
        int minStudentIndex = Array.IndexOf(studentAverages, minStudentAverage);

        // Нахождение максимального и минимального средних баллов среди предметов
        double maxSubjectAverage = subjectAverages.Max();
        double minSubjectAverage = subjectAverages.Min();
        int maxSubjectIndex = Array.IndexOf(subjectAverages, maxSubjectAverage);
        int minSubjectIndex = Array.IndexOf(subjectAverages, minSubjectAverage);

        // Вывод результатов
        Console.WriteLine("=== Средние баллы студентов ===");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Студент {i + 1}: {studentAverages[i]:F2}");
        }

        Console.WriteLine("\n=== Средние баллы предметов ===");
        for (int j = 0; j < M; j++)
        {
            Console.WriteLine($"Предмет {j + 1}: {subjectAverages[j]:F2}");
        }

        Console.WriteLine("\n=== Максимальный и минимальный средние баллы среди студентов ===");
        Console.WriteLine($"Максимальный средний балл студента: {maxStudentAverage:F2} (Студент {maxStudentIndex + 1})");
        Console.WriteLine($"Минимальный средний балл студента: {minStudentAverage:F2} (Студент {minStudentIndex + 1})");

        Console.WriteLine("\n=== Максимальный и минимальный средние баллы среди предметов ===");
        Console.WriteLine($"Максимальный средний балл предмета: {maxSubjectAverage:F2} (Предмет {maxSubjectIndex + 1})");
        Console.WriteLine($"Минимальный средний балл предмета: {minSubjectAverage:F2} (Предмет {minSubjectIndex + 1})");
    }
}
