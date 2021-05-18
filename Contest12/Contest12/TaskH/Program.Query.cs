using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    // Сортируем по возрастанию лексикографическому города и создаём на основе их группы.
    // Далее сортируем такие группы по количеству в них пользователей. Сортировка убавающая
    // Берём пять первых групп, не включая первую.
    // В каждой такой группе необходимо сгруппировать пользователей по имени, и уже каждую такую группу преобразовать в число, равное среднему возрасту этой группы.

    private static double GetAverage(IEnumerable<User> users)
    {
        throw new NotImplementedException();
    }
}