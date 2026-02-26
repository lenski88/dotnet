//16.Обобщенные типы(Generics)
//Задача: Создайте обобщенный класс Box<T>, который может хранить значение любого типа.
//Добавьте свойство Content типа T.
//Добавьте метод SwapContent(Box<T> other), который меняет содержимое текущего ящика с содержимым другого ящика того же типа.
//Протестируйте класс с типами int, string и собственным классом Item.


namespace extra0
{
    class Box<T>(T content)
    {
        public T Content { get; set; } = content;

        public void SwapContent(Box<T> other)
        {
            T curr = Content;

            Content = other.Content;

            other.Content = curr;
        }
    }

    class BoxItem
    {
        public string Inner { get; set; } = string.Empty;
    }
}
