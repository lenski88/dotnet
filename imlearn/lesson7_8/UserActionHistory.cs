//Задача 7. Stack

//Создайте класс UserActionHistory:
//ActionName
//DateTime Time

//Создай Stack<UserActionHistory> — история действий пользователя.
//Требуется:
//добавить 3 UserActionHistory в Main

//отменить последнее действие(убрать из стека)

//вывести текущее состояние стека



namespace lesson7_8
{
    class UserActionHistory(string name)
    {
        public DateTime Time { get; } = DateTime.Now;

        public string ActionName { get; } = name;
    }
}
